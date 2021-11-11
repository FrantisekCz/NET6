using Hello_World.Model;
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
using Hello_World.Data;
using WpfApp1.Data;

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
            /*
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
            */
        }

        private void btnOpenPersonDetail_Click(object sender, RoutedEventArgs e)
        {
            // nactu z gridu
            var osoba = (Person)grdPeople.SelectedItem;

            // vytvorime novou instanci okna
            var pdWindow = new PersonDetail(osoba, this);

            pdWindow.ShowDialog();
        }

        private void wMain_Loaded(object sender, RoutedEventArgs e)
        {
            // jen jednorazove
            //            NacistUvodniData();

            DataAccess.LoadPeopleFromDb();
            grdPeople.ItemsSource = DataAccess.people;
        }


        private void NacistUvodniData()
        {
            using (var db = new PeopleContext())
            {
                string sAdresar = @"C:\Users\Student\Desktop\2021-11 Školení C#\CNET1\01 HelloWorld\01 Hello World\Hello World\Data";
                string sSoubor = "ZapsaniLide.txt";
                var sCestaSouboru = System.IO.Path.Combine(sAdresar, sSoubor);
                var people = PersonData.LoadPeople(sCestaSouboru);
                // pridelime do DB contextu v pameti
                db.People.AddRange(people);
                // vlozime data do DB
                db.SaveChanges();
            }
        }




        private void grdPeople_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            btnOpenPersonDetail_Click(sender, e);
        }


        private void grdPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnOpenPersonDetail.IsEnabled = true;
        }

        private void btnAddPersonDetail_Click(object sender, RoutedEventArgs e)
        {
            // vytvorime novou instanci okna
            PersonDetail pdWindow = new PersonDetail( null, this, true );

            pdWindow.ShowDialog();

        }
    }
}
