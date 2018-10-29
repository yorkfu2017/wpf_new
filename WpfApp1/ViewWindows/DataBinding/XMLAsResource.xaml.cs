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
using System.Xml;

namespace WpfApp1.ViewWindows.DataBinding
{
    /// <summary>
    /// XMLAsResource.xaml 的交互逻辑
    /// </summary>
    public partial class XMLAsResource : Window
    {
        public XMLAsResource()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load(@"D:\VS_CODE\git_2\WpfApp1\ViewWindows\DataBinding\XMLFile1.xml");
            //XmlDataProvider xdp = new XmlDataProvider();
            //xdp.Document = doc;
            //另外一种方法
            //XmlDataProvider xdp = new XmlDataProvider();
            //xdp.Source = new Uri(@"D:\VS_CODE\git_2\WpfApp1\ViewWindows\DataBinding\XMLFile1.xml");
            //xdp.XPath = @"StudentList/Student";
            //this.listViewStudents.DataContext = xdp;
            //this.listViewStudents.SetBinding(ListView.ItemsSourceProperty,new Binding());
        }
    }
}
