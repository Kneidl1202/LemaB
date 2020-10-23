using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace LeMa_A
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Amount
        {
            public int amount = 0;
        }

        public MainWindow()
        {
            Amount am = new Amount
            {
                amount = 0
            };
            InitializeComponent();
            try
            {
                am.amount = Convert.ToInt32(File.ReadAllText("amount.txt"));
            }
            catch (IOException ex)
            {
                Console.WriteLine("Failed to open amount Page\n" + ex);
            }
            try
            {
                int counter = 0;

                if (am.amount == 0)
                {
                    counter = 0;
                }
                else
                {
                    counter = 8 * am.amount;
                }

                string[] textBoxes = File.ReadAllLines("seite1.txt");

                durchgefuehrtVon.Text = textBoxes[0 + counter];
                datum.Text = textBoxes[1 + counter];
                nameSchueler.Text = textBoxes[2 + counter];
                klasse.Text = textBoxes[3 + counter];
                schule.Text = textBoxes[4 + counter];
                geburtsDatum.Text = textBoxes[5 + counter];
                allgemeineAnmerkungen.Text = textBoxes[6 + counter];
                string mehrsprachig = textBoxes[7 + counter];

                string[] mehrsprachigarray = mehrsprachig.Split('#');

                foreach (string sprache in mehrsprachigarray)
                {
                    if (sprache == "deutsch")
                    {
                        deutschSprachig.IsChecked = true;
                    }
                    else if (sprache == "andereSprache")
                    {
                        andereSprache.IsChecked = true;
                        andereSpracheText.Text = mehrsprachigarray[1];
                    }
                    else if (sprache == "mehrSprachig")
                    {
                        mehrSprachig.IsChecked = true;
                        mehrSprachigText.Text = mehrsprachigarray[1];
                    }
                }
            }
            catch (IOException exception)
            {
                MessageBox.Show("The file could not be read: " + exception.Message);
            }
        }

        private void weiter_Click(object sender, RoutedEventArgs e)
        {
            Amount am = new Amount
            {
                amount = Convert.ToInt32(File.ReadAllText("amount.txt"))
            };

            string[] textBoxes = new string[8];

            textBoxes[0] = durchgefuehrtVon.Text;
            textBoxes[1] = datum.Text;
            textBoxes[2] = nameSchueler.Text;
            textBoxes[3] = klasse.Text;
            textBoxes[4] = schule.Text;
            textBoxes[5] = geburtsDatum.Text;
            textBoxes[6] = allgemeineAnmerkungen.Text;

            if (deutschSprachig.IsChecked == true)
            {
                textBoxes[7] = "deutsch";
            }
            else if (andereSprache.IsChecked == true)
            {
                textBoxes[7] = "andereSprache" + "#" + andereSpracheText.Text;
            }
            else if (mehrSprachig.IsChecked == true)
            {
                textBoxes[7] = "mehrSprachig" + "#" + mehrSprachigText.Text;
            }

            string[] old = new string[0];
            string[] save = new string[textBoxes.Length];

            if (am.amount != 0)
            {
                try
                {
                    old = File.ReadAllLines("seite1.txt");
                    save = new string[(8 * am.amount) + textBoxes.Length];
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Keine alten Einträge vorhanden!\n" + ex);
                }
            }
            int i = 0;

            for (int j = 0; j < 8 * am.amount; j++)
            {
                save[i] = old[i];
                i++;
            }

            foreach (string item in textBoxes)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite1.txt", save);

            Seite2 s2 = new Seite2();
            s2.Show();

            this.Close();
        }

        private void speichern_Click(object sender, RoutedEventArgs e)
        {
            Amount am = new Amount
            {
                amount = Convert.ToInt32(File.ReadAllText("amount.txt"))
            };

            string[] textBoxes = new string[8];

            textBoxes[0] = durchgefuehrtVon.Text;
            textBoxes[1] = datum.Text;
            textBoxes[2] = nameSchueler.Text;
            textBoxes[3] = klasse.Text;
            textBoxes[4] = schule.Text;
            textBoxes[5] = geburtsDatum.Text;
            textBoxes[6] = allgemeineAnmerkungen.Text;

            if (deutschSprachig.IsChecked == true)
            {
                textBoxes[7] = "deutsch";
            }
            else if (andereSprache.IsChecked == true)
            {
                textBoxes[7] = "andereSprache" + "#" + andereSpracheText.Text;
            }
            else if (mehrSprachig.IsChecked == true)
            {
                textBoxes[7] = "mehrSprachig" + "#" + mehrSprachigText.Text;
            }

            string[] old = new string[0];
            string[] save = new string[textBoxes.Length];

            if (am.amount != 0)
            {
                try
                {
                    old = File.ReadAllLines("seite1.txt");
                    save = new string[(8 * am.amount) + textBoxes.Length];
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Keine alten Einträge vorhanden!\n" + ex);
                }
            }

            int i = 0;

            for (int j = 0; j < 8 * am.amount; j++)
            {
                save[i] = old[i];
                i++;
            }

            foreach (string item in textBoxes)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite1.txt", save);
        }

        private void durchgefuehrtVon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void datum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void nameSchueler_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void klasse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void schule_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void geburtsDatum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void deutschSprachig_Checked(object sender, RoutedEventArgs e)
        {
            andereSprache.IsChecked = false;
            mehrSprachig.IsChecked = false;
        }

        private void andereSprache_Checked(object sender, RoutedEventArgs e)
        {
            deutschSprachig.IsChecked = false;
            mehrSprachig.IsChecked = false;
        }

        private void mehrSprachig_Checked(object sender, RoutedEventArgs e)
        {
            deutschSprachig.IsChecked = false;
            andereSprache.IsChecked = false;
        }

        private void allgemeineAnmerkungen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
