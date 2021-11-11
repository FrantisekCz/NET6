using Hello_World.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
using WpfApp1.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PersonDetail.xaml
    /// </summary>
    public partial class PersonDetail : Window
    {
        Person osoba;
        MainWindow mainWindow; // zde bude odkaz na hlavni okno
        bool isNewPerson = false;


        public PersonDetail( Person _osoba, MainWindow _mainWindow, bool _isNewPerson = false )  // osoba a odkaz na puvodni okno
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            isNewPerson = _isNewPerson;


            if (isNewPerson)
            {
                // vytvorim novou
                osoba = new Person();
            }
            else
            {
                // prevezmu z parametru
                osoba = _osoba;
            }

            txtFirstName.Text = osoba.KrestniJmeno;
            txtLastName.Text = osoba.Prijmeni;
            txtBirthDate.Text = osoba.DatumNarozeni.ToShortDateString();


        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // ulozime data z formu do objektu
            osoba.KrestniJmeno = txtFirstName.Text;
            osoba.Prijmeni = txtLastName.Text;
            osoba.DatumNarozeni = DateTime.Parse(txtBirthDate.Text);

            // z objektu do dat
            if( isNewPerson)
            {
                // pridani noveho zaznamu
                DataAccess.AddPerson(osoba);
            }
            else
            {
                // ulozeni zmeny
                DataAccess.SavePerson(osoba);
            }

            // přenačtu všechna data ze zdroje
            DataAccess.LoadPeopleFromDb();

            // refresh gridu
            mainWindow.grdPeople.ItemsSource = DataAccess.people;
            // zavre okno
            this.Close();

        }


    }
}
