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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PersonDetail.xaml
    /// </summary>
    public partial class PersonDetail : Window
    {
        Person osoba;


        public PersonDetail( Person _osoba)
        {
            InitializeComponent();
            osoba = _osoba;

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
            File.AppendAllText("osobyWPF.txt", osoba.ToString() + Environment.NewLine);
        }
    }
}
