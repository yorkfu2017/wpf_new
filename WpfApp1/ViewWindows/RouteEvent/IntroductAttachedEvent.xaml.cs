using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1.ViewWindows.RouteEvent
{
    //附加事件 看看这个类的定义
    public class Student
    {
        public static readonly RoutedEvent NameChangeEvent = EventManager.RegisterRoutedEvent(
            "NameChanged",RoutingStrategy.Bubble,typeof(RoutedEventHandler),typeof(Student)
            );
        public static void  AddNameChangeHandler(DependencyObject d,RoutedEventHandler h )
        {
            UIElement e = d as UIElement;
            if (e!=null)
            {
                e.AddHandler(Student.NameChangeEvent,h);
            }
        }
        public static void RemoveNameChangeHandler(DependencyObject d, RoutedEventHandler h)
        {
            UIElement e = d as UIElement;
            if (e != null)
            {
                e.RemoveHandler(Student.NameChangeEvent, h);
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    /// <summary>
    /// IntroductAttachedEvent.xaml 的交互逻辑  
    /// </summary>
    public partial class IntroductAttachedEvent : Window
    {
        public IntroductAttachedEvent()
        {
            InitializeComponent();
            Student.AddNameChangeHandler(this.gridMain,new RoutedEventHandler(this.StudentNameChangedHandler));
        }
        private  void StudentNameChangedHandler(object sender,RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as Student).Id.ToString());
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student() { Id = 101, Name = "Tim" };
            stu.Name = "Tom";
            RoutedEventArgs arg = new RoutedEventArgs(Student.NameChangeEvent,stu);
            this.button_OK.RaiseEvent(arg);
        }
    }
}
