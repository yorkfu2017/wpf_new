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
    class City
    {
        public string  Name { get; set; }
        public List<City> CityList { get; set; }
    }
    class Province 
    {
        public string  Name { get; set; }
        public List<City> CityList { get; set; }

    }
    class Country
    {
        public string Name { get; set; }
        public List<Province> ProvinceList { get; set; }
    }
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        List<String> stringlist = new List<string>() {"york","tom","andy","wang","andys"};
        
        public Window1()
        {
            InitializeComponent();
            //在codebehind实现databinding 
            #region databinding 
            //Binding binding = new Binding() { Path = new PropertyPath("Value"), Source = this.slider1 };
            //this.textBox1.SetBinding(TextBox.TextProperty, binding);
            Binding binding = new Binding("value") { Source = this.slider1 };
            this.textBox1.SetBinding(TextBox.TextProperty, binding);
            //< TextBox x: Name = "textBox2"  Width = "200" Text = "{Binding Path=Text.Length, ElementName=TextBox1, Mode=OneWay}" ></ TextBox >
            //this.textBox4.SetBinding(TextBox.TextProperty, new Binding("Text.[3]") {Source = this.TextBox3, Mode = BindingMode.OneWay });
            #endregion
            //this.TextBox3.SetBinding(TextBox.TextProperty,new Binding("/[1]") { Source =stringlist,Mode=BindingMode.OneWay});
            //this.textBox4.SetBinding(TextBox.TextProperty,new Binding("/") { Source =stringlist, Mode = BindingMode.OneWay  });

            List<Country> countryList = new List<Country> {
                new Country { Name="中国", ProvinceList=new List< Province > {
                   new Province {
                       Name="江苏", CityList =new List<City>
                       {
                           new City (){ Name  ="苏州"}, new City (){ Name  ="吴江"}, new City (){ Name  ="常熟"}, new City (){ Name  ="无锡"}
                       }
                   },
                    new Province{
                         Name="江西", CityList =new List<City>
                       {
                           new City (){ Name  ="南昌"}, new City (){ Name  ="赣州"}, new City (){ Name  ="九江"}
                       }
                   },
                    new Province{
                         Name="河南", CityList =new List<City>
                       {
                           new City (){ Name  ="信阳"}, new City (){ Name  ="开封"}
                       }
                   }
                } },
                new Country { Name="american", ProvinceList=new List< Province > {
                   new Province {
                       Name="newyork", CityList =new List<City>
                       {
                           new City (){ Name  ="ss"}, new City (){ Name  ="xx"}, new City (){ Name  ="yy"}, new City (){ Name  ="zz"}
                       }
                   }
                } },
               new Country { Name="england", ProvinceList=new List< Province > {
                   new Province {
                       Name="york", CityList =new List<City>
                       {
                           new City (){ Name  ="zz"}, new City (){ Name  ="tt"}, new City (){ Name  ="ss"}, new City (){ Name  ="ww"}
                       }
                   },
                   
                } },
            };
            this.textBox5.SetBinding(TextBox.TextProperty,new Binding("/Name"){Source =countryList });
            this.textBox6.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList/.Name") { Source = countryList });
            this.textBox7.SetBinding(TextBox.TextProperty, new Binding("/Provinces/CityList.Name") { Source = countryList });
            string MyString = "绿蚁新焙酒，红泥小火炉";
            this.textBlock1.SetBinding(TextBlock.TextProperty,new Binding(".") { Source=MyString});
        }
    }
}
