using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfApp1.ClassDevTest
{


    /*在研究c#的线程锁,
    Lock.Enter();
    WriteLine(commandString);
    rawResponse = ReadLine();
    Lock.Exit();
    */

        //这边放一个静态资源，当多个方法同时要操作这个资源的的时候，我们就需要使用同步了，原子操作，符合操作这些概念，java 里面讲的应该更清楚
    public class ResourceLockTest
    {
        public static int ResourceLockString = 0;
    }
    public class MethodsLockTest
    {
        private object objectForLock = new object();

        public void MyMethod1()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "---not locked in MyMethod1()");
            //这边呢，我们一般锁定会创建一个私有成员对象， 从而达到锁定 一个被实例化了的对象。lock (this) 就表示锁定当前类 我们还有锁定代码块等等
            lock (objectForLock)
            {
                for (int i = 0; i < 10; i++)
                {
                    ResourceLockTest.ResourceLockString += 1;
                    Console.WriteLine(Thread.CurrentThread.Name + "---locked in MyMethod1()当前循环号为:" + i + "---ResourceLockString的值为：" + ResourceLockTest.ResourceLockString);

                }
            }
        }
        public void MyMethod2()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "---not locked in MyMethod2()");
            lock (objectForLock)
            {
                for (int i = 0; i < 10; i++)
                {
                    ResourceLockTest.ResourceLockString += 1;
                    Console.WriteLine(Thread.CurrentThread.Name + "---locked in MyMethod2()当前循环号为:" + i + "---ResourceLockString的值为：" + ResourceLockTest.ResourceLockString);

                }
            }
        }
        public void MyMethod3()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "---not locked in MyMethod3()");
            lock (objectForLock)
            {
                for (int i = 0; i < 10; i++)
                {
                    ResourceLockTest.ResourceLockString += 1;
                    Console.WriteLine(Thread.CurrentThread.Name + "---locked in MyMethod3()当前循环号为:" + i + "---ResourceLockString的值为：" + ResourceLockTest.ResourceLockString);

                }
            }
        }

    }
    class ThreadLock
    {
        [DllImport("kernel32.dll")]
        extern public static int GetCurrentProcessorNumber();
        // static void Main(string[] args)
        static void Method()
        {
            Thread.CurrentThread.Name = "Main";
            MethodsLockTest methodsLockTest = new MethodsLockTest();
            Thread MyMehtod1 = new Thread(new ThreadStart(methodsLockTest.MyMethod1));
            MyMehtod1.Name = "MyMethod1";
            MyMehtod1.Start();


            Thread MyMehtod2 = new Thread(new ThreadStart(methodsLockTest.MyMethod2));
            MyMehtod2.Name = "MyMethod2";
            MyMehtod2.Start();


            methodsLockTest.MyMethod3();

            int myProcessorNum = GetCurrentProcessorNumber();
            Console.WriteLine(myProcessorNum);
            Console.ReadLine();

        }

    }
}
