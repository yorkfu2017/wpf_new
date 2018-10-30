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
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            InitializeCommand();
        }
        private RoutedCommand clearCmd = new RoutedCommand("Clear",typeof(Window1));
        private void InitializeCommand()
        {
            this.button1.Command = this.clearCmd;
            this.clearCmd.InputGestures.Add(new KeyGesture(Key.C,ModifierKeys.Alt));
            this.button1.CommandTarget = this.textBoxA;
            CommandBinding cb = new CommandBinding();
            cb.Command = this.clearCmd;
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);
            cb.Executed += new ExecutedRoutedEventHandler(cb_Executed);
            this.stackPanel.CommandBindings.Add(cb);
        }
        void cb_CanExecute(object sender ,CanExecuteRoutedEventArgs e )
        {
            if (string.IsNullOrEmpty(this.textBoxA.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            e.Handled = true;
        }
        void cb_Executed(object sender,ExecutedRoutedEventArgs e)
        {
            this.textBoxA.Clear();
            e.Handled = true;
        }
    }
}
