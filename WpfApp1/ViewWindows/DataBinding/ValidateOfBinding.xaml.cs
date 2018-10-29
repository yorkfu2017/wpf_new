using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class RangeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            
            //throw new NotImplementedException();
            double d = 0;
            if (double.TryParse(value.ToString(),out d ))
            {
                if (d>=0&&d<=100)
                {
                    return new ValidationResult(true,null);

                }
            }
            return new ValidationResult(false,"Validation  Failed");
        }
    }
    /// <summary>
    /// ValidateOfBinding.xaml 的交互逻辑
    /// </summary>
    public partial class ValidateOfBinding : Window
    {
        public ValidateOfBinding()
        {
             
            InitializeComponent();
            Binding binding = new Binding("Value") { Source = this.slider1 };
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            RangeValidationRule rvr = new RangeValidationRule();
            rvr.ValidatesOnTargetUpdated = true;
            binding.ValidationRules.Add(rvr);

           // binding.NotifyOnValidationError=true;
            this.textBox1.SetBinding(TextBox.TextProperty,binding);
            //this.textBox1.AddHandler(Validation.ErrorEvent,new RoutedEventHandler(this.ValidationError));
        }
        void ValidationError(object sender,RoutedEventHandler e)
        {
            if (Validation.GetErrors(this.textBox1).Count>0)
            {
                this.textBox1.ToolTip = Validation.GetErrors(this.textBox1)[0].ErrorContent.ToString();
            }
        }
    }
}
