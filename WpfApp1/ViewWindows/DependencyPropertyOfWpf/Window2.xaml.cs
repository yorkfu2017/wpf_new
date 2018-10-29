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

namespace WpfApp1.ViewWindows.DependencyPropertyOfWpf
{

    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {

        Student stu;
        public Window2()
        {
            InitializeComponent();
            stu = new Student();
            Binding binding = new Binding("Text") { Source = textBox1 };
            //BindingOperations.SetBinding(stu,Student.NameProperty,binding);
            //textBox2.SetBinding(TextBox.TextProperty,binding);
            stu.SetBinding(Student.NameProperty, new Binding("Text") { Source = textBox1 });
            //这个我们最好指明使用的mode是oneway还是twoway,否则默认是twoway
            //Text="{Binding Name, Mode=OneWay}"  lblName.DataContext = user; 这是一种前后端的写法，感觉还不如都写在后端好了
            textBox2.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu, Mode = BindingMode.OneWay });
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(stu.GetValue(Student.NameProperty).ToString());
        }


    }
}
