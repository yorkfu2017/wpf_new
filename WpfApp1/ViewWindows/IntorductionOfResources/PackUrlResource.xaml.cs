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
    /// PackUrlResource.xaml 的交互逻辑
    /// </summary>
    public partial class PackUrlResource : Window
    {
        public PackUrlResource()
        {
            
            InitializeComponent();
            Uri imgUri = new Uri(@"test1.jpg",UriKind.Relative);
            this.ImageBg2.Source = new BitmapImage(imgUri);
            Uri imgUri1 = new Uri(@"pack://application:,,,/ViewWindows/IntorductionOfResources/test2.jpg", UriKind.Absolute);
            this.ImageBg3.Source = new BitmapImage(imgUri1);
        }
    }
}
