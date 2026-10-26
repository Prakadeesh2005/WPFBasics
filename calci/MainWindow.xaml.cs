using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string firstnumber = "";
        string secondnumber = "";
        string oper = " ";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(Object sender, RoutedEventArgs e)
        {
            Button btnnumber = (Button)sender;
            // txtfirst.Text =Convert.ToString(btn7.Content);
            if (oper == " ")
            {
                firstnumber = firstnumber + btnnumber.Content.ToString();
                txtresult.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + btnnumber.Content.ToString();
                txtresult.Text = secondnumber;
            }
        }

        private void Oper_Click(Object sender, RoutedEventArgs e)
        {
            Button btnoper
                = (Button)sender;
            oper = btnoper.Content.ToString();

        }
        private void btnequal_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(firstnumber);
            int num2 = Convert.ToInt32(secondnumber);
            int result = 0;
            if (oper == "+")
            {
                result = num1 + num2;
            }
            else if (oper == "-")
            {
                result = num1 - num2;
            }
            else if (oper == "*")
            {
                result = num1 * num2;
            }

            else if (oper == "/")
            {
                result = num1 / num2;
            }

            txtresult.Text = result.ToString();

        }
        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = "";
            secondnumber = "";
            oper = " ";
            txtresult.Text = "";
        }
    }
}