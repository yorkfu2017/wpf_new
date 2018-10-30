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

namespace WpfApp1.ViewWindows.RouteEvent
{
    class ReportTimeEventArgs : RoutedEventArgs
    {
        public ReportTimeEventArgs(RoutedEvent routedEvent, object source) : base(routedEvent, source)
        {

        }
        public DateTime ClickTime { get; set; }
    }
    class TimeButton : Button
    {
        //RoutingStrategy.Tunnel 缺点
        //RoutingStrategy.Direct 
        //RoutingStrategy.Bubble 
        public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent("ReportTime",
            RoutingStrategy.Tunnel, typeof(EventHandler<ReportTimeEventArgs>), typeof(TimeButton));
        public event RoutedEventHandler ReportTime
        {
            add { this.AddHandler(ReportTimeEvent, value); }
            remove { this.RemoveHandler(ReportTimeEvent, value); }
        }
        protected override void OnClick()
        {
            //RoutedEventArgs e = new RoutedEventArgs(ClickEvent, this);
            //base.RaiseEvent(e);
            base.OnClick();
            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent, this);
            args.ClickTime = DateTime.Now;
            this.RaiseEvent(args);
        }
    }
    /// <summary>
    /// CustomerRouteEvent.xaml 的交互逻辑  是我的问题  学习周期  其实都是现学现卖
    /// </summary>
    public partial class CustomerRouteEvent : Window
    {
        public CustomerRouteEvent()
        {
            InitializeComponent();
        }

        private void ReportTimeHandler(object sender, ReportTimeEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            string timeStr = e.ClickTime.ToLongTimeString();
            string content = string.Format("{0}到达{1}", timeStr, element.Name);
            this.listBox.Items.Add(content);
            if (element==this.grid_2)
            {
                e.Handled = true;
            }
        }
    }
}
