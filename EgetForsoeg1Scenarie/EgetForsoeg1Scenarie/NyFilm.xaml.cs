using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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

namespace EgetForsoeg1Scenarie
{
    /// <summary>
    /// Interaction logic for NyFilm.xaml
    /// </summary>
    public partial class NyFilm : Page
    {
        private string filepath = @"C:\Users\peter\OneDrive\Desktop\UCL\2. Semester\Programmering og teknologi\The Movies\Eget forsøg 1. Scenarie\filmdata.CSV";

        public NyFilm()
        {
            InitializeComponent();
        }

        private void TilføjFilm_Click(object sender, RoutedEventArgs e)
        {
            string titel = tbTitel.Text;
            int varighed;
            if (!int.TryParse(tbVarighed.Text, out varighed))
            {
                MessageBox.Show("Varighed skal være et tal");
                return;
            }
            string genre = tbGenre.Text;

            string csvLine = $"{titel},{varighed},{genre}";

            try
            {
                using (StreamWriter sw = new StreamWriter(filepath, true))
                {
                    sw.WriteLine(csvLine);
                }


                MessageBox.Show($"Film tilføjet:\nTitel: {titel}\nVarighed: {varighed}\nGenre: {genre}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl under skriving til fil: {ex.Message}");
            }
        }

        private void Ryd_Click(object sender, RoutedEventArgs e)
        {
            tbTitel.Clear();
            tbVarighed.Clear();
            tbGenre.Clear();
        }
    }
}
