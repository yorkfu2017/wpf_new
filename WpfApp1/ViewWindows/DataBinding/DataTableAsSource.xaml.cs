using System;
using System.Collections.Generic;
using System.Data;
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
    public static class Resource_wpf
    {
      
        

    }
    /// <summary>
    /// DataTableAsSource.xaml 的交互逻辑
    /// </summary>
    public partial class DataTableAsSource : Window
    {
       
       
        public DataTableAsSource()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable Load = new DataTable();
            Load.Columns.Add("Id", typeof(string));
            Load.Columns.Add("Name", typeof(string));
            Load.Columns.Add("Age",typeof(string));
            Load.Rows.Add(new object[] { "1","Tim","29"});
            Load.Rows.Add(new object[] { "2", "Tim1", "2309" });
            Load.Rows.Add(new object[] { "3", "Tim2", "31" });
            Load.Rows.Add(new object[] { "4", "Tim3", "29" });
            Load.Rows.Add(new object[] { "5", "Tim4", "111" });
            Load.Rows.Add(new object[] { "6", "Tim5", "22" });
            Load.Rows.Add(new object[] { "7", "Tim6", "33" });
            this.listBoxStudents.DisplayMemberPath = "Name";
            this.listBoxStudents.ItemsSource = Load.DefaultView;

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            DataTable Load = new DataTable();
            Load.Columns.Add("Id", typeof(string));
            Load.Columns.Add("Name", typeof(string));
            Load.Columns.Add("Age", typeof(string));
            Load.Rows.Add(new object[] { "1", "Tim", "29" });
            Load.Rows.Add(new object[] { "2", "Tim1", "2309" });
            Load.Rows.Add(new object[] { "3", "Tim2", "31" });
            Load.Rows.Add(new object[] { "4", "Tim3", "29" });
            Load.Rows.Add(new object[] { "5", "Tim4", "111" });
            Load.Rows.Add(new object[] { "6", "Tim5", "22" });
            Load.Rows.Add(new object[] { "7", "Tim6", "33" });
            //this.listViewStudents.DisplayMemberPath = "Name";
            //this.listViewStudents.ItemsSource = Load.DefaultView;
            this.listViewStudents.DataContext = Load;
            this.listViewStudents.SetBinding(ListView.ItemsSourceProperty,new Binding());
        }
    }
}
