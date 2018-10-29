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
    public class Student5
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    /// <summary>
    /// LinqAsResource.xaml 的交互逻辑
    /// </summary>
    public partial class LinqAsResource : Window
    {
        public LinqAsResource()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Student> stuList = new List<Student>()
            {
                new Student() { Id=0,Name="Tim",Age=29},
                new Student() { Id=1,Name="Tim1",Age=29},
                new Student() { Id=2,Name="Tim2",Age=29},
                new Student() { Id=3,Name="Tim3",Age=29},
                new Student() { Id=4,Name="Tim4",Age=29},
                new Student() { Id=5,Name="Tim5",Age=29}
            };
            //从list列表中取值
            //this.listViewStudents.ItemsSource = from stu in stuList where stu.Name.StartsWith("T") select stu;
            DataTable dt = new DataTable();
            dt.Columns.Add("Id",typeof(int));
            dt.Columns.Add("Name",typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Rows.Add(new Object[] { 1,"Tim",29});
            dt.Rows.Add(new Object[] { 2, "Tim1", 29 });
            dt.Rows.Add(new Object[] { 3, "Tim2", 29 });
            dt.Rows.Add(new Object[] { 4, "Tim3", 29 });
            //从datatable 中
            //this.listViewStudents.ItemsSource = from row in dt.Rows.Cast<DataRow>()
            //                                    where Convert.ToString(row["Name"]).StartsWith("T")
            //                                    select new Student()
            //                                    {
            //                                        Id = int.Parse(row["Id"].ToString()),
            //                                        Name = row["Name"].ToString(),
            //                                        Age = int.Parse(row["Age"].ToString())
            //                                    };


            //
            //ObjectDataProvider odp = new ObjectDataProvider();
            //odp.ObjectInstance=new 
        }
    }
}
