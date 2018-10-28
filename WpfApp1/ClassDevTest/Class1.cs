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
    public class ResourceLockTest
    {
        public static int ResourceLockString = 0;
    }
    public class MethodsLockTest
    {

        public void MyMethod1()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "---not locked in MyMethod1()");
            lock (this)
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
            lock (this)
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
            lock (this)
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
