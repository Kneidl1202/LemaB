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

namespace LeMa_A
{
    /// <summary>
    /// Interaktionslogik für seite4.xaml
    /// </summary>
    public partial class seite4 : Window
    {
        public seite4()
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
                    counter = amount * 14;
                }

                string[] opened = File.ReadAllLines("seite4.txt");

                if (opened[0 + counter] == "ja")
                {
                    Ja1.IsChecked = true;
                }
                else if (opened[0 + counter] == "nein")
                {
                    nein1.IsChecked = true;
                }
                if (opened[1 + counter] == "ja")
                {
                    Ja2.IsChecked = true;
                }
                else if (opened[1 + counter] == "nein")
                {
                    nein2.IsChecked = true;
                }
                if (opened[2 + counter] == "ja")
                {
                    Ja3.IsChecked = true;
                }
                else if (opened[2 + counter] == "nein")
                {
                    nein3.IsChecked = true;
                }
                if (opened[3 + counter] == "ja")
                {
                    Ja4.IsChecked = true;
                }
                else if (opened[3 + counter] == "nein")
                {
                    nein4.IsChecked = true;
                }
                if (opened[4 + counter] == "ja")
                {
                    Ja5.IsChecked = true;
                }
                else if (opened[4 + counter] == "nein")
                {
                    nein5.IsChecked = true;
                }
                if (opened[5 + counter] == "ja")
                {
                    Ja6.IsChecked = true;
                }
                else if (opened[5 + counter] == "nein")
                {
                    nein6.IsChecked = true;
                }
                if (opened[6 + counter] == "ja")
                {
                    Ja7.IsChecked = true;
                }
                else if (opened[6 + counter] == "nein")
                {
                    nein7.IsChecked = true;
                }
                if (opened[7 + counter] == "ja")
                {
                    Ja8.IsChecked = true;
                }
                else if (opened[7 + counter] == "nein")
                {
                    nein8.IsChecked = true;
                }
                if (opened[8 + counter] == "ja")
                {
                    Ja9.IsChecked = true;
                }
                else if (opened[8 + counter] == "nein")
                {
                    nein9.IsChecked = true;
                }
                if (opened[9 + counter] == "ja")
                {
                    Ja10.IsChecked = true;
                }
                else if (opened[9 + counter] == "nein")
                {
                    nein10.IsChecked = true;
                }

                beobachtungen1.Text = opened[10 + counter];
                beobachtungen2.Text = opened[11 + counter];
                erklaerung1.Text = opened[12 + counter];
                erklaerung2.Text = opened[13 + counter];
            }
            catch(IOException exception)
            {
                MessageBox.Show("The file could not be read: " + exception.Message);
            }
        }

        private void weiter_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(File.ReadAllText("amount.txt"));
            string[] safe = new string[14];

            if (Ja1.IsChecked == true)
            {
                safe[0] = "ja";
            }
            else if (nein1.IsChecked == true)
            {
                safe[0] = "nein";
            }
            if (Ja2.IsChecked == true)
            {
                safe[1] = "ja";
            }
            else if (nein2.IsChecked == true)
            {
                safe[1] = "nein";
            }
            if (Ja3.IsChecked == true)
            {
                safe[2] = "ja";
            }
            else if (nein3.IsChecked == true)
            {
                safe[2] = "nein";
            }
            if (Ja4.IsChecked == true)
            {
                safe[3] = "ja";
            }
            else if (nein4.IsChecked == true)
            {
                safe[3] = "nein";
            }
            if (Ja5.IsChecked == true)
            {
                safe[4] = "ja";
            }
            else if (nein5.IsChecked == true)
            {
                safe[4] = "nein";
            }
            if (Ja6.IsChecked == true)
            {
                safe[5] = "ja";
            }
            else if (nein6.IsChecked == true)
            {
                safe[5] = "nein";
            }
            if (Ja7.IsChecked == true)
            {
                safe[6] = "ja";
            }
            else if (nein7.IsChecked == true)
            {
                safe[6] = "nein";
            }
            if (Ja8.IsChecked == true)
            {
                safe[7] = "ja";
            }
            else if (nein8.IsChecked == true)
            {
                safe[7] = "nein";
            }
            if (Ja9.IsChecked == true)
            {
                safe[8] = "ja";
            }
            else if (nein9.IsChecked == true)
            {
                safe[8] = "nein";
            }
            if (Ja10.IsChecked == true)
            {
                safe[9] = "ja";
            }
            else if (nein10.IsChecked == true)
            {
                safe[9] = "nein";
            }

            safe[10] = beobachtungen1.Text;
            safe[11] = beobachtungen2.Text;
            safe[12] = erklaerung1.Text;
            safe[13] = erklaerung2.Text;

            string[] old = new string[0];
            string[] save = new string[safe.Length];

            try
            {
                old = File.ReadAllLines("seite4.txt");
                save = new string[amount * 14 + safe.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten Daten Vorhanden!" + ex);
            }

            int i = 0;

            for (int j = 0; j < amount * 14; j++)
            {
                save[i] = old[i];
                i++;
            }
            foreach (string item in safe)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite4.txt", save);

            seite5 s5 = new seite5();
            s5.Show();

            this.Close();
        }

        private void speichern_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(File.ReadAllText("amount.txt"));
            string[] safe = new string[14];

            if (Ja1.IsChecked == true)
            {
                safe[0] = "ja";
            }
            else if (nein1.IsChecked == true)
            {
                safe[0] = "nein";
            }
            if (Ja2.IsChecked == true)
            {
                safe[1] = "ja";
            }
            else if (nein2.IsChecked == true)
            {
                safe[1] = "nein";
            }
            if (Ja3.IsChecked == true)
            {
                safe[2] = "ja";
            }
            else if (nein3.IsChecked == true)
            {
                safe[2] = "nein";
            }
            if (Ja4.IsChecked == true)
            {
                safe[3] = "ja";
            }
            else if (nein4.IsChecked == true)
            {
                safe[3] = "nein";
            }
            if (Ja5.IsChecked == true)
            {
                safe[4] = "ja";
            }
            else if (nein5.IsChecked == true)
            {
                safe[4] = "nein";
            }
            if (Ja6.IsChecked == true)
            {
                safe[5] = "ja";
            }
            else if (nein6.IsChecked == true)
            {
                safe[5] = "nein";
            }
            if (Ja7.IsChecked == true)
            {
                safe[6] = "ja";
            }
            else if (nein7.IsChecked == true)
            {
                safe[6] = "nein";
            }
            if (Ja8.IsChecked == true)
            {
                safe[7] = "ja";
            }
            else if (nein8.IsChecked == true)
            {
                safe[7] = "nein";
            }
            if (Ja9.IsChecked == true)
            {
                safe[8] = "ja";
            }
            else if (nein9.IsChecked == true)
            {
                safe[8] = "nein";
            }
            if (Ja10.IsChecked == true)
            {
                safe[9] = "ja";
            }
            else if (nein10.IsChecked == true)
            {
                safe[9] = "nein";
            }

            safe[10] = beobachtungen1.Text;
            safe[11] = beobachtungen2.Text;
            safe[12] = erklaerung1.Text;
            safe[13] = erklaerung2.Text;

            string[] old = new string[0];
            string[] save = new string[safe.Length];

            try
            {
                old = File.ReadAllLines("seite4.txt");
                save = new string[amount * 14 + safe.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten Daten Vorhanden!" + ex);
            }

            int i = 0;

            for (int j = 0; j < amount * 14; j++)
            {
                save[i] = old[i];
                i++;
            }
            foreach (string item in safe)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite4.txt", save);
        }

        private void Ja1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
