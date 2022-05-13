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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double h, z, p, a, b;
            a = Convert.ToDouble(FirstVariable.Text);
            b = Convert.ToDouble(SecondVariable.Text);
            h = Convert.ToDouble(ThirdVariable.Text);
            p = 3*(Math.Pow(a, 2)+ Math.Pow(b,2));
            z = ((Math.PI * h) / (6)) * (p + Math.Pow(h, 2));
            listbox1.Items.Add("z = "+z);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
