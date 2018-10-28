using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1.ViewWindows.DependencyPropertyOfWpf
{
    //public class Student : DependencyObject
    //{

    //    public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name", typeof(String), typeof(Student));
    //}
    public class Student:DependencyObject,INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(Student));

        

        public BindingExpressionBase SetBinding(DependencyProperty dp,BindingBase binding)
      {

          return BindingOperations.SetBinding(this,dp,binding);
      }


        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Age.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(int), typeof(Student), new PropertyMetadata(0));

       
    }

    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
       
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student();
            stu.SetValue(Student.NameProperty,this.textBox1.Text);
            textBox2.Text = (string)stu.GetValue(Student.NameProperty);
        }
    }
}
