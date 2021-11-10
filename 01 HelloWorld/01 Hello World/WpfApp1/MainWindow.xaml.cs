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

namespace WpfApp1
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
            if (txtVstupni.Text.Trim() == "")
            {
                txbInfo.Text = "HA, klikl jsi na tlačítko!";
                btnKlikni.Content = "Paráda, viď?";

                Color c = new Color();
                c.R = 10;
                c.G = 10;
                c.B = 10;
                c.A = 100;
                wMain.Background = new SolidColorBrush(c);
            }

            else
            {
                txbInfo.Text = "Jé, tys mi zadal nějakou hodnotu!" + Environment.NewLine + "Tak já pojmenuju tlačítko.";
                btnKlikni.Content = txtVstupni.Text.Trim();
                lsvSeznam.Items.Add(txtVstupni.Text.Trim());
                txtVstupni.Text = "";
                txtVstupni.Focus();

            }

        }

        private void btnOpenPersonDetail_Click(object sender, RoutedEventArgs e)
        {
            // vytvorime novou instanci okna
            var pdWindow = new PersonDetail();
            pdWindow.Show();
        }
    }
}
