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
using WpfApp1.ViewWindows;
namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WpfApp1.ViewWindows.DataBinding.Window1 main = new WpfApp1.ViewWindows.DataBinding.Window1();
            App.Current.MainWindow = main;
            //this.Close();
            main.Show();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            WpfApp1.ViewWindows.DependencyPropertyOfWpf.Window2 main = new WpfApp1.ViewWindows.DependencyPropertyOfWpf.Window2();
            App.Current.MainWindow = main;
            //this.Close();
            main.Show();
        }
        //WpfApp1.ViewWindows.RouteEvent
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            WpfApp1.ViewWindows.RouteEvent.IntroductAttachedEvent main = new WpfApp1.ViewWindows.RouteEvent.IntroductAttachedEvent();
            App.Current.MainWindow = main;
            //this.Close();
            main.Show();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            WpfApp1.ViewWindows.IntroductionOfCommand.CustomerCommandMain main = new WpfApp1.ViewWindows.IntroductionOfCommand.CustomerCommandMain();
            App.Current.MainWindow = main;
            //this.Close();
            main.Show();
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            WpfApp1.ViewWindows.IntorductionOfResources.PackUrlResource main = new WpfApp1.ViewWindows.IntorductionOfResources.PackUrlResource();
            App.Current.MainWindow = main;
            //this.Close();
            main.Show();
        }
    }
}
