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

namespace WpfApp1.ViewWindows.IntroductionOfCommand
{
    /// <summary>
    /// CustomerCommandMain.xaml 的交互逻辑
    /// </summary>
    public partial class CustomerCommandMain : Window
    {
        public CustomerCommandMain()
        {
            InitializeComponent();
            ClearCommand clearCmd = new ClearCommand();
            this.ctrlClear.Command = clearCmd;
            this.ctrlClear.CommandTarget = this.miniView;
        }
    }
}
