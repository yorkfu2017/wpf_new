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
    /// StaticAndDynamicResource.xaml 的交互逻辑
    /// </summary>
    public partial class StaticAndDynamicResource : Window
    {
        public StaticAndDynamicResource()
        {
            InitializeComponent();
        }
       private void  Button_Click(object sender ,RoutedEventArgs e)
        {//因为引用res1的button 引用的是静态资源，所以资源被更新了它也不会知道
            this.Resources["res1"] = new TextBlock() {Text="天涯共此时" };
            this.Resources["res2"] = new TextBlock() { Text = "天涯共此时" };
        }
    }
}
