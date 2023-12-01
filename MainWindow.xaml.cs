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

        private void txbFerfi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && txbFerfi.Text != "" && txbFerfi.Text.Contains(" ") && !(lbFerfiak.Items.Contains(txbFerfi.Text)))
            {
                lbFerfiak.Items.Add(txbFerfi.Text);
                txbFerfi.Text = "";
            }
        }
        private void txbNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && txbNo.Text != "" && txbNo.Text.Contains(" ") && !(lbNok.Items.Contains(txbNo.Text)))
            {
                lbNok.Items.Add(txbNo.Text);
                txbNo.Text = "";
            }
        }

        private void btnMix_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int kevesebb = lbFerfiak.Items.Count >= lbNok.Items.Count ? lbNok.Items.Count : lbFerfiak.Items.Count;
            for (int i = 0; i < kevesebb; i++)
            {
                int elso = r.Next(lbFerfiak.Items.Count - 1);
                int masodik = r.Next(lbNok.Items.Count - 1);
                lbMixeltNevek.Items.Add(lbFerfiak.Items.GetItemAt(elso) + " + " + (lbNok.Items.GetItemAt(masodik)));
                lbFerfiak.Items.RemoveAt(elso);
                lbNok.Items.RemoveAt(masodik);
            }
        }
    }
}
