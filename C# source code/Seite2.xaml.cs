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
using System.Threading;

namespace LeMa_A
{
    /// <summary>
    /// Interaktionslogik für Seite2.xaml
    /// </summary>
    public partial class Seite2 : Window
    {
        public class Amount
        {
            public int amount = 0;
        }

        public Seite2()
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
                int counterCheckBoxes = 0, counterTextBoxes = 0;

                if (am.amount == 0)
                {
                    counterCheckBoxes = 0;
                    counterTextBoxes = 0;
                }
                else
                {
                    counterCheckBoxes = 8 * am.amount;
                    counterTextBoxes = 18 * am.amount;
                }

                string[] checkboxes = File.ReadAllLines("seite2checkboxes.txt");
                string[] textboxes = File.ReadAllLines("seite2textboxes.txt");

                if (checkboxes[0 + counterCheckBoxes] == "-")
                {
                    verstaendnis1.IsChecked = true;
                }
                else if (checkboxes[0 + counterCheckBoxes] == "--")
                {
                    verstaendnis2.IsChecked = true;
                }
                if (checkboxes[1 + counterCheckBoxes] == "---")
                {
                    verstaendnis3.IsChecked = true;
                }
                else if (checkboxes[1 + counterCheckBoxes] == "----")
                {
                    verstaendnis4.IsChecked = true;
                }
                if (checkboxes[2 + counterCheckBoxes] == "1-")
                {
                    spontan5.IsChecked = true;
                }
                if (checkboxes[3 + counterCheckBoxes] == "2-")
                {
                    spontan7.IsChecked = true;
                }
                if (checkboxes[4 + counterCheckBoxes] == "3-")
                {
                    spontan10.IsChecked = true;
                }
                if (checkboxes[5 + counterCheckBoxes] == "4-")
                {
                    spontan9.IsChecked = true;
                }
                if (checkboxes[6 + counterCheckBoxes] == "5-")
                {
                    spontan12.IsChecked = true;
                }
                if (checkboxes[7 + counterCheckBoxes] == "6-")
                {
                    spontan16.IsChecked = true;
                }
                if (checkboxes[2 + counterCheckBoxes] == "1--")
                {
                    garnicht5.IsChecked = true;
                }
                if (checkboxes[3 + counterCheckBoxes] == "2--")
                {
                    garnicht7.IsChecked = true;
                }
                if (checkboxes[4 + counterCheckBoxes] == "3--")
                {
                    garnicht10.IsChecked = true;
                }
                if (checkboxes[5 + counterCheckBoxes] == "4--")
                {
                    garnicht9.IsChecked = true;
                }
                if (checkboxes[6 + counterCheckBoxes] == "5--")
                {
                    garnicht12.IsChecked = true;
                }
                if (checkboxes[7 + counterCheckBoxes] == "6--")
                {
                    garnicht16.IsChecked = true;
                }

                falsch5.Text = textboxes[0 + counterTextBoxes];
                falsch7.Text = textboxes[1 + counterTextBoxes];
                falsch9.Text = textboxes[2 + counterTextBoxes];
                falsch10.Text = textboxes[3 + counterTextBoxes];
                falsch12.Text = textboxes[4 + counterTextBoxes];
                falsch16.Text = textboxes[5 + counterTextBoxes];
                nicht5.Text = textboxes[6 + counterTextBoxes];
                nicht7.Text = textboxes[7 + counterTextBoxes];
                nicht9.Text = textboxes[8 + counterTextBoxes];
                nicht10.Text = textboxes[9 + counterTextBoxes];
                nicht12.Text = textboxes[10 + counterTextBoxes];
                nicht16.Text = textboxes[11 + counterTextBoxes];
                bei5.Text = textboxes[12 + counterTextBoxes];
                bei7.Text = textboxes[13 + counterTextBoxes];
                bei9.Text = textboxes[14 + counterTextBoxes];
                bei10.Text = textboxes[15 + counterTextBoxes];
                bei12.Text = textboxes[16 + counterTextBoxes];
                bei16.Text = textboxes[17 + counterTextBoxes];
            }
            catch (IOException exception)
            {
                MessageBox.Show("The file could not be read: " + exception.Message);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            verstaendnis2.IsChecked = false;
        }

        private void verstaendnis2_Checked(object sender, RoutedEventArgs e)
        {
            verstaendnis1.IsChecked = false;
        }

        private void verstaendnis3_Checked(object sender, RoutedEventArgs e)
        {
            verstaendnis4.IsChecked = false;
        }

        private void verstaendnis4_Checked(object sender, RoutedEventArgs e)
        {
            verstaendnis3.IsChecked = false;
        }        

        private void Weiter_Click(object sender, RoutedEventArgs e)
        {
            Amount am = new Amount 
            { 
                amount = Convert.ToInt32(File.ReadAllText("amount.txt"))
            };


            string[] checkBoxes = new string[8];
            string[] textBoxes = new string[18];

            if (verstaendnis1.IsChecked == true)
            {
                checkBoxes[0] = "-";
            }
            else if (verstaendnis2.IsChecked == true)
            {
                checkBoxes[0] = "--";
            }
            if (verstaendnis3.IsChecked == true)
            {
                checkBoxes[1] = "---";
            }
            else if (verstaendnis4.IsChecked == true)
            {
                checkBoxes[1] = "----";
            }
            if (spontan5.IsChecked == true)
            {
                checkBoxes[2] = "1-";
            }
            if (spontan7.IsChecked == true)
            {
                checkBoxes[3] = "2-";
            }
            if (spontan10.IsChecked == true)
            {
                checkBoxes[4] = "3-";
            }
            if (spontan9.IsChecked == true)
            {
                checkBoxes[5] = "4-";
            }
            if (spontan12.IsChecked == true)
            {
                checkBoxes[6] = "5-";
            }
            if (spontan16.IsChecked == true)
            {
                checkBoxes[7] = "6-";
            }
            if (garnicht5.IsChecked == true)
            {
                checkBoxes[2] = "1--";
            }
            if (garnicht7.IsChecked == true)
            {
                checkBoxes[3] = "2--";
            }
            if (garnicht10.IsChecked == true)
            {
                checkBoxes[4] = "3--";
            }
            if (garnicht9.IsChecked == true)
            {
                checkBoxes[5] = "4--";
            }
            if (garnicht12.IsChecked == true)
            {
                checkBoxes[6] = "5--";
            }
            if (garnicht16.IsChecked == true)
            {
                checkBoxes[7] = "6--";
            }

            textBoxes[0] = falsch5.Text;
            textBoxes[1] = falsch7.Text;
            textBoxes[2] = falsch9.Text;
            textBoxes[3] = falsch10.Text;
            textBoxes[4] = falsch12.Text;
            textBoxes[5] = falsch16.Text;
            textBoxes[6] = nicht5.Text;
            textBoxes[7] = nicht7.Text;
            textBoxes[8] = nicht9.Text;
            textBoxes[9] = nicht10.Text;
            textBoxes[10] = nicht12.Text;
            textBoxes[11] = nicht16.Text;
            textBoxes[12] = bei5.Text;
            textBoxes[13] = bei7.Text;
            textBoxes[14] = bei9.Text;
            textBoxes[15] = bei10.Text;
            textBoxes[16] = bei12.Text;
            textBoxes[17] = bei16.Text;

            string[] old = new string[0];
            string[] save = new string[checkBoxes.Length];

            try
            {
                old = File.ReadAllLines("seite2checkboxes.txt");
                save = new string[8 * am.amount + checkBoxes.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten Einträge vorhanden!\n" + ex);
            }

            int i = 0;

            for (int j = 0; j < 8 * am.amount; j++)
            {
                save[i] = old[i];
                i++;
            }

            foreach (string item in checkBoxes)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite2checkboxes.txt", save);


            save = new string[textBoxes.Length];

            try
            {
                old = File.ReadAllLines("seite2textboxes.txt");
                save = new string[28 * am.amount + textBoxes.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten Einträge vorhanden!\n" + ex);
            }

            i = 0;

            for (int j= 0; j < 18 * am.amount; j++)
            {
                save[i] = old[i];
                i++;
            }

            foreach (string item in textBoxes)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite2textboxes.txt", save);

            seite3 s3 = new seite3();
            s3.Show();

            this.Close();
        }

        private void Speichern_Click_1(object sender, RoutedEventArgs e)
        {
            Amount am = new Amount
            {
                amount = Convert.ToInt32(File.ReadAllText("amount.txt"))
            };


            string[] checkBoxes = new string[8];
            string[] textBoxes = new string[18];

            if (verstaendnis1.IsChecked == true)
            {
                checkBoxes[0] = "-";
            }
            else if (verstaendnis2.IsChecked == true)
            {
                checkBoxes[0] = "--";
            }
            if (verstaendnis3.IsChecked == true)
            {
                checkBoxes[1] = "---";
            }
            else if (verstaendnis4.IsChecked == true)
            {
                checkBoxes[1] = "----";
            }
            if (spontan5.IsChecked == true)
            {
                checkBoxes[2] = "1-";
            }
            if (spontan7.IsChecked == true)
            {
                checkBoxes[3] = "2-";
            }
            if (spontan10.IsChecked == true)
            {
                checkBoxes[4] = "3-";
            }
            if (spontan9.IsChecked == true)
            {
                checkBoxes[5] = "4-";
            }
            if (spontan12.IsChecked == true)
            {
                checkBoxes[6] = "5-";
            }
            if (spontan16.IsChecked == true)
            {
                checkBoxes[7] = "6-";
            }
            if (garnicht5.IsChecked == true)
            {
                checkBoxes[2] = "1--";
            }
            if (garnicht7.IsChecked == true)
            {
                checkBoxes[3] = "2--";
            }
            if (garnicht10.IsChecked == true)
            {
                checkBoxes[4] = "3--";
            }
            if (garnicht9.IsChecked == true)
            {
                checkBoxes[5] = "4--";
            }
            if (garnicht12.IsChecked == true)
            {
                checkBoxes[6] = "5--";
            }
            if (garnicht16.IsChecked == true)
            {
                checkBoxes[7] = "6--";
            }

            textBoxes[0] = falsch5.Text;
            textBoxes[1] = falsch7.Text;
            textBoxes[2] = falsch9.Text;
            textBoxes[3] = falsch10.Text;
            textBoxes[4] = falsch12.Text;
            textBoxes[5] = falsch16.Text;
            textBoxes[6] = nicht5.Text;
            textBoxes[7] = nicht7.Text;
            textBoxes[8] = nicht9.Text;
            textBoxes[9] = nicht10.Text;
            textBoxes[10] = nicht12.Text;
            textBoxes[11] = nicht16.Text;
            textBoxes[12] = bei5.Text;
            textBoxes[13] = bei7.Text;
            textBoxes[14] = bei9.Text;
            textBoxes[15] = bei10.Text;
            textBoxes[16] = bei12.Text;
            textBoxes[17] = bei16.Text;

            string[] old = new string[0];
            string[] save = new string[checkBoxes.Length];

            try
            {
                old = File.ReadAllLines("seite2checkboxes.txt");
                save = new string[8 * am.amount + checkBoxes.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten Einträge vorhanden!\n" + ex);
            }

            int i = 0;

            for (int j = 0; j < 8 * am.amount; j++)
            {
                save[i] = old[i];
                i++;
            }

            foreach (string item in checkBoxes)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite2checkboxes.txt", save);


            save = new string[textBoxes.Length];

            try
            {
                old = File.ReadAllLines("seite2textboxes.txt");
                save = new string[28 * am.amount + textBoxes.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten Einträge vorhanden!\n" + ex);
            }

            i = 0;

            for (int j = 0; j < 18 * am.amount; j++)
            {
                save[i] = old[i];
                i++;
            }

            foreach (string item in textBoxes)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite2textboxes.txt", save);
        }

        private void nicht9_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void spontan5_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void falsch5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void nicht5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bei5_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void garnicht5_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
