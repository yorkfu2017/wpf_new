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
using WpfApp1.Sources;
namespace WpfApp1.ViewWindows
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
            //stu = new Student();
            //Binding binding = new Binding();
            //binding.Source = stu;
            //binding.Path = new PropertyPath("Sex");
            //BindingOperations.SetBinding(this.textBoxName,TextBox.TextProperty,binding);
            this.textBoxName.SetBinding(TextBox.TextProperty,new Binding("Name") { Source =stu =new Student()});
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stu.Name += "york";
        }
    }
}
