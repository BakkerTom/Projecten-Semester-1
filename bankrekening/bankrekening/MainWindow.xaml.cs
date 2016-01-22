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

namespace bankrekening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Bankrekening bankrekeningLinks;
        private Bankrekening bankrekeningRechts;

        public MainWindow()
        {
            InitializeComponent();

            bankrekeningLinks = new Bankrekening("Duck, Dagobert");
            bankrekeningRechts = new Bankrekening("Gans, Gijs");
        }

        private void btnTransferForward_Click(object sender, RoutedEventArgs e)
        {
              
        }

        private void updateInformation()
        {
            lblRekening1.Content = bankrekeningLinks.Rekeningnummer.ToString();
            lblRekening2.Content = bankrekeningRechts.Rekeningnummer.ToString();

            lblNaam1.Content = bankrekeningLinks.Naam;
            lblNaam2.Content = bankrekeningRechts.Naam;

            Decimal eurosLeft = bankrekeningLinks.Saldo / 100m;
            Decimal eurosRight = bankrekeningRechts.Saldo / 100m;

            lblSaldo1.Content = eurosLeft.ToString("C");
            lblSaldo2.Content = eurosRight.ToString("C");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateInformation();   
        }

        private void btnOpnemen1_Click(object sender, RoutedEventArgs e)
        {
            int bedrag = convertHeleCenten(txtInput1.Text);
            if (bedrag != 0)
            {
                bankrekeningLinks.NeemOp(bedrag);
                updateInformation();
            }
            else
            {
                MessageBox.Show("Vul een geldig getal in.");
            }
          
        }

        private void btnStorten1_Click(object sender, RoutedEventArgs e)
        {
            int bedrag = convertHeleCenten(txtInput1.Text);
            if (bedrag != 0)
            {
                bankrekeningLinks.Stort(bedrag);
                updateInformation();
            }
            else
            {
                MessageBox.Show("Vul een geldig getal in.");
            }
        }

        private void btnOpnemen2_Click(object sender, RoutedEventArgs e)
        {
            int bedrag = convertHeleCenten(txtInput2.Text);
            if (bedrag != 0)
            {
                bankrekeningRechts.NeemOp(bedrag);
                updateInformation();
            }
            else
            {
                MessageBox.Show("Vul een geldig getal in.");
            }

        }

        private void btnStorten2_Click(object sender, RoutedEventArgs e)
        {
            int bedrag = convertHeleCenten(txtInput2.Text);
            if (bedrag != 0) {
                bankrekeningRechts.Stort(bedrag);
                updateInformation();
            }
            else
            {
                MessageBox.Show("Vul een geldig getal in.");
            }
        }

        private void btnTransferForward_Click_1(object sender, RoutedEventArgs e)
        {
            int bedrag = convertHeleCenten(txtInput1.Text);
            if (bedrag != 0) {
                MessageBox.Show(bankrekeningLinks.MaakOver(bankrekeningRechts, bedrag));
                updateInformation();
            }
            else
            {
                MessageBox.Show("Vul een geldig getal in.");
            }

        }

        private void btnTransferBackward_Click(object sender, RoutedEventArgs e)
        {
            int bedrag = convertHeleCenten(txtInput2.Text);
            if (bedrag != 0)
            {
                MessageBox.Show(bankrekeningRechts.MaakOver(bankrekeningLinks, bedrag));
                updateInformation();
            }
            else
            {
                MessageBox.Show("Vul een geldig getal in.");
            }

        }

        private int convertHeleCenten(string input) {
            if (input.IndexOf(",") >= 0)
            {
                string removedComma = input.Replace(",", "");
                int converted = Convert.ToInt32(removedComma);
                return converted;
            }
            else
            {
                return 0;
            }
        }
    }
}
