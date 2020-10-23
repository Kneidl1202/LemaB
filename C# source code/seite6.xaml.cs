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
using System.Windows.Shapes;
using System.IO;

//TODO in excel convertieren

namespace LeMa_A
{
    /// <summary>
    /// Interaktionslogik für seite6.xaml
    /// </summary>
    public partial class seite6 : Window
    {
        public seite6()
        {
            InitializeComponent();

            try
            {                
                int amount = Convert.ToInt32(File.ReadAllText("amount.txt"));
                int counter = 0;

                if (amount == 0)
                {
                    counter = 0;
                }
                else
                {
                    counter = amount * 9;
                }

                string[] opened = File.ReadAllLines("seite6.txt");
                string[] nein = new string[6];
                string[] temp = new string[2];

                for (int i = 0; i < 6; i++)
                {
                    if (opened[i] != "ja" && opened[i] != "")
                    {
                        temp = opened[i].Split(' ');
                    }
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (temp[j] != "nein")
                        {
                            nein[i] = temp[j];
                        }
                    }
                }

                if (opened[0 + counter] == "ja")
                {
                    ja1.IsChecked = true;
                }
                else if (opened[0 + counter] != "")
                {
                    nein1.IsChecked = true;
                    neinText1.Text = nein[0];
                }
                if (opened[1 + counter] == "ja")
                {
                    ja2.IsChecked = true;
                }
                else if (opened[1 + counter] != "")
                {
                    nein2.IsChecked = true;
                    neinText2.Text = nein[1];
                }
                if (opened[2 + counter] == "ja")
                {
                    ja3.IsChecked = true;
                }
                else if (opened[2 + counter] != "")
                {
                    nein3.IsChecked = true;
                    neinText3.Text = nein[2];
                }
                if (opened[3 + counter] == "ja")
                {
                    ja4.IsChecked = true;
                }
                else if (opened[3 + counter] != "")
                {
                    nein4.IsChecked = true;
                    neinText4.Text = nein[3];
                }
                if (opened[4 + counter] == "ja")
                {
                    ja5.IsChecked = true;
                }
                else if (opened[4 + counter] != "")
                {
                    nein5.IsChecked = true;
                    neinText5.Text = nein[4];
                }
                if (opened[5 + counter] == "ja")
                {
                    ja6.IsChecked = true;
                }
                else if (opened[5 + counter] != "")
                {
                    nein6.IsChecked = true;
                    neinText6.Text = nein[5];
                }

                beobachtungen1.Text = opened[6 + counter];
                beobachtungen2.Text = opened[7 + counter];
                beobachtungen3.Text = opened[8 + counter];
            }
            catch (IOException e)
            {
                MessageBox.Show("File could not be found: " + e.Message);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(File.ReadAllText("amount.txt"));
            string[] safe = new string[9];

            if (ja1.IsChecked == true)
            {
                safe[0] = "ja";
            }
            else if (nein1.IsChecked == true)
            {
                safe[0] = "nein" + " " + neinText1.Text; 
            }
            if (ja2.IsChecked == true)
            {
                safe[1] = "ja";
            }
            else if (nein2.IsChecked == true)
            {
                safe[1] = "nein" + " " + neinText2.Text;
            }
            if (ja3.IsChecked == true)
            {
                safe[2] = "ja";
            }
            else if (nein3.IsChecked == true)
            {
                safe[2] = "nein" + " " + neinText3.Text;
            }
            if (ja4.IsChecked == true)
            {
                safe[3] = "ja";
            }
            else if (nein4.IsChecked == true)
            {
                safe[3] = "nein" + " " + neinText4.Text;
            }
            if (ja5.IsChecked == true)
            {
                safe[4] = "ja";
            }
            else if (nein5.IsChecked == true)
            {
                safe[4] = "nein" + " " + neinText5.Text;
            }
            if (ja6.IsChecked == true)
            {
                safe[5] = "ja";
            }
            else if (nein6.IsChecked == true)
            {
                safe[5] = "nein" + " " + neinText6.Text;
            }

            safe[6] = beobachtungen1.Text;
            safe[7] = beobachtungen2.Text;
            safe[8] = beobachtungen3.Text;

            string[] old = new string[0];
            string[] save = new string[safe.Length];

            try
            {
                old = File.ReadAllLines("seite6.txt");
                save = new string[amount * 9 + safe.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten Daten Vorhanden!" + ex);
            }

            int i = 0;

            for (int j = 0; j < amount * 9; j++)
            {
                save[i] = old[i];
                i++;
            }
            foreach (string item in safe)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite6.txt", save);
        }

        private void weiter_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(File.ReadAllText("amount.txt"));
            string[] safe = new string[9];

            if (ja1.IsChecked == true)
            {
                safe[0] = "ja";
            }
            else if (nein1.IsChecked == true)
            {
                safe[0] = "nein" + " " + neinText1.Text;
            }
            if (ja2.IsChecked == true)
            {
                safe[1] = "ja";
            }
            else if (nein2.IsChecked == true)
            {
                safe[1] = "nein" + " " + neinText2.Text;
            }
            if (ja3.IsChecked == true)
            {
                safe[2] = "ja";
            }
            else if (nein3.IsChecked == true)
            {
                safe[2] = "nein" + " " + neinText3.Text;
            }
            if (ja4.IsChecked == true)
            {
                safe[3] = "ja";
            }
            else if (nein4.IsChecked == true)
            {
                safe[3] = "nein" + " " + neinText4.Text;
            }
            if (ja5.IsChecked == true)
            {
                safe[4] = "ja";
            }
            else if (nein5.IsChecked == true)
            {
                safe[4] = "nein" + " " + neinText5.Text;
            }
            if (ja6.IsChecked == true)
            {
                safe[5] = "ja";
            }
            else if (nein6.IsChecked == true)
            {
                safe[5] = "nein" + " " + neinText6.Text;
            }

            safe[6] = beobachtungen1.Text;
            safe[7] = beobachtungen2.Text;
            safe[8] = beobachtungen3.Text;

            string[] old = new string[0];
            string[] save = new string[safe.Length];

            try
            {
                old = File.ReadAllLines("seite6.txt");
                save = new string[amount * 9 + safe.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten Daten Vorhanden!" + ex);
            }

            int i = 0;

            for (int j = 0; j < amount * 9; j++)
            {
                save[i] = old[i];
                i++;
            }
            foreach (string item in safe)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite6.txt", save);

            Siete7 s7 = new Siete7();
            s7.Show();

            this.Close();
        }
    }
}
