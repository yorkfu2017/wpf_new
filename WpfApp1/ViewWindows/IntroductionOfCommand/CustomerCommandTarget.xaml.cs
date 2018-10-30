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
    public interface IView
    {
        bool IsChanged { get; set; }
        void SetBinding();
        void Refresh();
        void Clear();
        void Save();
    }

    public class ClearCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            IView view = parameter as IView;
            if(view !=null)
            {
                view.Clear();
            }
        }
    }
    public class MyCommandSource : UserControl, ICommandSource
    {
        public ICommand Command { get; set; }

        public object CommandParameter { get; set; }

        public IInputElement CommandTarget { get; set; }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if (this.CommandTarget != null)
            {
                this.Command.Execute(this.CommandTarget);
            }
        }
    }
    /// <summary>
    /// CustomerCommand.xaml 的交互逻辑
    /// </summary>
    public partial class CustomerCommandTarget : UserControl,IView
    {
        public CustomerCommandTarget()
        {
            InitializeComponent();
        }

        public bool IsChanged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Clear()
        {
            //throw new NotImplementedException();
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SetBinding()
        {
            throw new NotImplementedException();
        }
    }
}
