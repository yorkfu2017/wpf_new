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

namespace WpfApp1.ViewWindows.IntorductionOfResources
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            string text = (string)this.FindResource("str");
            this.textBlock1.Text = text;
            string text1 = (string)this.Resources["str"];
            this.textBlock2.Text = text1;
        }
        private void Window1_Load(object sender,RoutedEventArgs e)
        {
            string text = (string)this.FindResource("str");
            this.textBlock1.Text = text;
            string text1 = (string)this.Resources["str"];
            this.textBlock2.Text = text1;
        }
    }
}
