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

namespace WpfApp1.ViewWindows.DataBinding
{
   public  class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
    }
    /// <summary>
    /// DataContextAsResource.xaml 的交互逻辑
    /// </summary>
    public partial class DataContextAsResource : Window
    {
        public DataContextAsResource()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(btn.DataContext.ToString());
        }
    }
}
