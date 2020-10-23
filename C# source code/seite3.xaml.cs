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
    /// Interaktionslogik für seite3.xaml
    /// </summary>
    public partial class seite3 : Window
    {
        public seite3()
        {
            InitializeComponent();

            try
            {
                int amount = Convert.ToInt32(File.ReadAllText("amount.txt")), counter = 0;

                if (amount == 0)
                {
                    counter = 0;
                }
                else
                {
                    counter = amount * 30;
                }

                string[] opened = File.ReadAllLines("seite3.txt");

                if (opened[0 + counter] == "auto")
                {
                    automatisiert1.IsChecked = true;
                }
                else if (opened[0 + counter] == "nicht")
                {
                    antwortetNicht1.IsChecked = true;
                }
                if (opened[1 + counter] == "auto")
                {
                    automatisiert2.IsChecked = true;
                }
                else if (opened[1 + counter] == "nicht")
                {
                    antwortetNicht2.IsChecked = true;
                }
                if (opened[2 + counter] == "auto")
                {
                    automatisiert3.IsChecked = true;
                }
                else if (opened[2 + counter] == "nicht")
                {
                    antwortetNicht3.IsChecked = true;
                }
                if (opened[3 + counter] == "auto")
                {
                    automatisiert4.IsChecked = true;
                }
                else if (opened[3 + counter] == "nicht")
                {
                    antwortetNicht4.IsChecked = true;
                }
                if (opened[4 + counter] == "auto")
                {
                    auto5.IsChecked = true;
                }
                else if (opened[4 + counter] == "nicht")
                {
                    antwortetNicht5.IsChecked = true;
                }
                if (opened[5 + counter] == "auto")
                {
                    automatisiert6.IsChecked = true;
                }
                else if (opened[5 + counter] == "nicht")
                {
                    antwortetNicht6.IsChecked = true;
                }

                dauer1.Text = opened[6 + counter];
                dauer2.Text = opened[7 + counter];
                dauer3.Text = opened[8 + counter];
                dauer4.Text = opened[9 + counter];
                dauer5.Text = opened[10 + counter];
                dauer6.Text = opened[11 + counter];

                nor_counting_1.Text = opened[12 + counter];
                nor_counting_2.Text = opened[13 + counter];
                nor_counting_3.Text = opened[14 + counter];
                nor_counting_4.Text = opened[15 + counter];
                nor_counting_5.Text = opened[16 + counter];
                nor_counting_6.Text = opened[17 + counter];

                counting_1.Text = opened[18 + counter];
                counting_2.Text = opened[19 + counter];
                counting_3.Text = opened[20 + counter];
                counting_4.Text = opened[21 + counter];
                counting_5.Text = opened[22 + counter];
                counting_6.Text = opened[23 + counter];

                falsch1.Text = opened[24 + counter];
                falsch2.Text = opened[25 + counter];
                falsch3.Text = opened[26 + counter];
                falsch4.Text = opened[27 + counter];
                falsch5.Text = opened[28 + counter];
                falsch6.Text = opened[29 + counter];
            }
            catch (IOException exception)
            {
                MessageBox.Show("The file could not be read: " + exception.Message);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }  

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_6(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_7(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_8(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_9(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_10(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_11(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_12(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_13(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_14(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_15(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_16(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_17(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_5(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_18(object sender, TextChangedEventArgs e)
        {

        }

        private void a_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_6(object sender, RoutedEventArgs e)
        {

        }

        private void automatisiert5(object sender, RoutedEventArgs e)
        {

        }

        private void automatisiert1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void automatisiert2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void automatisiert3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void automatisiert4_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void automatisiert5_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void automatisiert6_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void dauer1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dauer3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dauer2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dauer4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dauer5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dauer6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Beschreibung1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Beschreibung2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Beschreibung3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Beschreibung4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Beschreibung5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Beschreibung6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void falsch1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void falsch2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void falsch3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void falsch4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void falsch5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void falsch6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void garnicht1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void garnicht2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void garnicht3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void garnicht4_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void garnicht5_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void garnicht6_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void weiter_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(File.ReadAllText("amount.txt"));

            string[] speichern = new string[30];

            if (automatisiert1.IsChecked == true)
            {
                speichern[0] = "auto";
            }
            else if (antwortetNicht1.IsChecked == true)
            {
                speichern[0] = "nicht";
            }
            if (automatisiert2.IsChecked == true)
            {
                speichern[1] = "auto";
            }
            else if (antwortetNicht2.IsChecked == true)
            {
                speichern[1] = "nicht";
            }
            if (automatisiert3.IsChecked == true)
            {
                speichern[2] = "auto";
            }
            else if (antwortetNicht3.IsChecked == true)
            {
                speichern[2] = "nicht";
            }
            if (automatisiert4.IsChecked == true)
            {
                speichern[3] = "auto";
            }
            else if (antwortetNicht4.IsChecked == true)
            {
                speichern[3] = "nicht";
            }
            if (auto5.IsChecked == true)
            {
                speichern[4] = "auto";
            }
            else if (antwortetNicht5.IsChecked == true)
            {
                speichern[4] = "nicht";
            }
            if (automatisiert6.IsChecked == true)
            {
                speichern[5] = "auto";
            }
            else if (antwortetNicht6.IsChecked == true)
            {
                speichern[5] = "nicht";
            }

            speichern[6] = dauer1.Text;
            speichern[7] = dauer2.Text;
            speichern[8] = dauer3.Text;
            speichern[9] = dauer4.Text;
            speichern[10] = dauer5.Text;
            speichern[11] = dauer6.Text;

            speichern[12] = nor_counting_1.Text;
            speichern[13] = nor_counting_2.Text;
            speichern[14] = nor_counting_3.Text;
            speichern[15] = nor_counting_4.Text;
            speichern[16] = nor_counting_5.Text;
            speichern[17] = nor_counting_6.Text;

            speichern[18] = counting_1.Text;
            speichern[19] = counting_2.Text;
            speichern[20] = counting_3.Text;
            speichern[21] = counting_4.Text;
            speichern[22] = counting_5.Text;
            speichern[23] = counting_6.Text;

            speichern[24] = falsch1.Text;
            speichern[25] = falsch2.Text;
            speichern[26] = falsch3.Text;
            speichern[27] = falsch4.Text;
            speichern[28] = falsch5.Text;
            speichern[29] = falsch6.Text;

            string[] old = new string[0];
            string[] save = new string[speichern.Length];

            try
            {
                old = File.ReadAllLines("seite3.txt");
                save = new string[amount * 30 + speichern.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten dateien!!\n" + ex);
            }

            int i = 0;

            for (int j = 0; j < amount * 30; j++)
            {
                save[i] = old[i];
                i++;
            }

            foreach (string item in speichern)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite3.txt", save);

            seite4 s4 = new seite4();
            s4.Show();

            this.Close();
        }

        private void speichern_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(File.ReadAllText("amount.txt"));

            string[] speichern = new string[30];

            if (automatisiert1.IsChecked == true)
            {
                speichern[0] = "auto";
            }
            else if (antwortetNicht1.IsChecked == true)
            {
                speichern[0] = "nicht";
            }
            if (automatisiert2.IsChecked == true)
            {
                speichern[1] = "auto";
            }
            else if (antwortetNicht2.IsChecked == true)
            {
                speichern[1] = "nicht";
            }
            if (automatisiert3.IsChecked == true)
            {
                speichern[2] = "auto";
            }
            else if (antwortetNicht3.IsChecked == true)
            {
                speichern[2] = "nicht";
            }
            if (automatisiert4.IsChecked == true)
            {
                speichern[3] = "auto";
            }
            else if (antwortetNicht4.IsChecked == true)
            {
                speichern[3] = "nicht";
            }
            if (auto5.IsChecked == true)
            {
                speichern[4] = "auto";
            }
            else if (antwortetNicht5.IsChecked == true)
            {
                speichern[4] = "nicht";
            }
            if (automatisiert6.IsChecked == true)
            {
                speichern[5] = "auto";
            }
            else if (antwortetNicht6.IsChecked == true)
            {
                speichern[5] = "nicht";
            }

            speichern[6] = dauer1.Text;
            speichern[7] = dauer2.Text;
            speichern[8] = dauer3.Text;
            speichern[9] = dauer4.Text;
            speichern[10] = dauer5.Text;
            speichern[11] = dauer6.Text;

            speichern[12] = nor_counting_1.Text;
            speichern[13] = nor_counting_2.Text;
            speichern[14] = nor_counting_3.Text;
            speichern[15] = nor_counting_4.Text;
            speichern[16] = nor_counting_5.Text;
            speichern[17] = nor_counting_6.Text;

            speichern[18] = counting_1.Text;
            speichern[19] = counting_2.Text;
            speichern[20] = counting_3.Text;
            speichern[21] = counting_4.Text;
            speichern[22] = counting_5.Text;
            speichern[23] = counting_6.Text;

            speichern[24] = falsch1.Text;
            speichern[25] = falsch2.Text;
            speichern[26] = falsch3.Text;
            speichern[27] = falsch4.Text;
            speichern[28] = falsch5.Text;
            speichern[29] = falsch6.Text;

            string[] old = new string[0];
            string[] save = new string[speichern.Length];

            try
            {
                old = File.ReadAllLines("seite3.txt");
                save = new string[amount * 30 + speichern.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten dateien!!\n" + ex);
            }

            int i = 0;

            for (int j = 0; j < amount * 30; j++)
            {
                save[i] = old[i];
                i++;
            }

            foreach (string item in speichern)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite3.txt", save);
        }
    }
}
