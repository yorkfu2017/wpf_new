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

namespace WpfApp1.ViewWindows.DataBinding
{
    //FrameworkElementFacotry text  = ContentPresenter.CreateTextBlockFactory();
    /// <summary>
    /// ListItemSource.xaml 的交互逻辑
    /// </summary>
    public partial class ListItemSource : Window
    {

        public ListItemSource()
        {
            InitializeComponent();

            
            List<Student> stulist = new List<Student>()
            {
             new Student(){Id=0,Name="Tim",Age=29},
             new Student(){Id=1,Name="las",Age=30},
             new Student(){Id=2,Name="lns",Age=19},
             new Student(){Id=3,Name="york",Age=25},
             new Student(){Id=4,Name="lan",Age=24}
            };
            this.ListBoxStudents.ItemsSource = stulist;
            //this.ListBoxStudents.DisplayMemberPath = "Name";
            Binding binding = new Binding("SelectedItem.Id") { Source = this.ListBoxStudents };
        }
    }
}
