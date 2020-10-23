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
    /// Interaktionslogik für seite5.xaml
    /// </summary>
    public partial class seite5 : Window
    {
        public seite5()
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
                    counter = amount * 180;
                }

                string[] opened = File.ReadAllLines("seite5.txt");

                zeit1.Text = opened[0 + counter];
                zeit2.Text = opened[1 + counter];
                zeit3.Text = opened[2 + counter];
                zeit4.Text = opened[3 + counter];
                zeit5.Text = opened[4 + counter];
                zeit6.Text = opened[5 + counter];
                zeit7.Text = opened[6 + counter];
                zeit8.Text = opened[7 + counter];
                zeit9.Text = opened[8 + counter];
                zeit10.Text = opened[9 + counter];
                zeit11.Text = opened[10 + counter];
                zeit12.Text = opened[11 + counter];
                zeit13.Text = opened[12 + counter];
                zeit14.Text = opened[13 + counter];
                zeit15.Text = opened[14 + counter];

                ergebnis1.Text = opened[15 + counter];
                ergebnis2.Text = opened[16 + counter];
                ergebnis3.Text = opened[17 + counter];
                ergebnis4.Text = opened[18 + counter];
                ergebnis5.Text = opened[19 + counter];
                ergebnis6.Text = opened[10 + counter];
                ergebnis7.Text = opened[21 + counter];
                ergebnis8.Text = opened[22 + counter];
                ergebnis9.Text = opened[23 + counter];
                ergebnis10.Text = opened[24 + counter];
                ergebnis11.Text = opened[25 + counter];
                ergebnis12.Text = opened[26 + counter];
                ergebnis13.Text = opened[27 + counter];
                ergebnis14.Text = opened[28 + counter];
                ergebnis15.Text = opened[29 + counter];

                CheckBox[] checkArray = new CheckBox[150] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24, checkBox25, checkBox26, checkBox27, checkBox28, checkBox29, checkBox30, checkBox31, checkBox32, checkBox33, checkBox34, checkBox35, checkBox36, checkBox37, checkBox38, checkBox39, checkBox40, checkBox41, checkBox42, checkBox43, checkBox44, checkBox45, checkBox46, checkBox47, checkBox48, checkBox49, checkBox50, checkBox51, checkBox52, checkBox53, checkBox54, checkBox55, checkBox56, checkBox57, checkBox58, checkBox59, checkBox60, checkBox61, checkBox62, checkBox63, checkBox64, checkBox65, checkBox66, checkBox67, checkBox68, checkBox69, checkBox70, checkBox71, checkBox72, checkBox73, checkBox74, checkBox75, checkBox76, checkBox77, checkBox78, checkBox79, checkBox80, checkBox81, checkBox82, checkBox83, checkBox84, checkBox85, checkBox86, checkBox87, checkBox88, checkBox89, checkBox90, checkBox91, checkBox92, checkBox93, checkBox94, checkBox95, checkBox96, checkBox97, checkBox98, checkBox99, checkBox100, checkBox101, checkBox102, checkBox103, checkBox104, checkBox105, checkBox106, checkBox107, checkBox108, checkBox109, checkBox110, checkBox111, checkBox112, checkBox113, checkBox114, checkBox115, checkBox116, checkBox117, checkBox118, checkBox119, checkBox120, checkBox121, checkBox122, checkBox123, checkBox124, checkBox125, checkBox126, checkBox127, checkBox128, checkBox129, checkBox130, checkBox131, checkBox132, checkBox133, checkBox134, checkBox135, checkBox136, checkBox137, checkBox138, checkBox139, checkBox140, checkBox141, checkBox142, checkBox143, checkBox144, checkBox145, checkBox146, checkBox147, checkBox148, checkBox149, checkBox150, };
                int i = 30;

                foreach (CheckBox item in checkArray)
                {
                    if (opened[i] == "true")
                    {
                        item.IsChecked = true;
                    }
                    else
                    {
                        item.IsChecked = false;
                    }
                    i++;
                }
            }
            catch(IOException exception)
            {
                MessageBox.Show("The file could not be found: " + exception.Message);
            }
        }

        private void weiter_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(File.ReadAllText("amount.txt"));
            string[] safe = new string[180];

            safe[0] = zeit1.Text;
            safe[1] = zeit2.Text;
            safe[2] = zeit3.Text;
            safe[3] = zeit4.Text;
            safe[4] = zeit5.Text;
            safe[5] = zeit6.Text;
            safe[6] = zeit7.Text;
            safe[7] = zeit8.Text;
            safe[8] = zeit9.Text;
            safe[9] = zeit10.Text;
            safe[10] = zeit11.Text;
            safe[11] = zeit12.Text;
            safe[12] = zeit13.Text;
            safe[13] = zeit14.Text;
            safe[14] = zeit15.Text;

            safe[15] = ergebnis1.Text;
            safe[16] = ergebnis2.Text;
            safe[17] = ergebnis3.Text;
            safe[18] = ergebnis4.Text;
            safe[19] = ergebnis5.Text;
            safe[20] = ergebnis6.Text;
            safe[21] = ergebnis7.Text;
            safe[22] = ergebnis8.Text;
            safe[23] = ergebnis9.Text;
            safe[24] = ergebnis10.Text;
            safe[25] = ergebnis11.Text;
            safe[26] = ergebnis12.Text;
            safe[27] = ergebnis13.Text;
            safe[28] = ergebnis14.Text;
            safe[29] = ergebnis15.Text;

            CheckBox[] checkArray = new CheckBox[150] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24, checkBox25, checkBox26, checkBox27, checkBox28, checkBox29, checkBox30, checkBox31, checkBox32, checkBox33, checkBox34, checkBox35, checkBox36, checkBox37, checkBox38, checkBox39, checkBox40, checkBox41, checkBox42, checkBox43, checkBox44, checkBox45, checkBox46, checkBox47, checkBox48, checkBox49, checkBox50, checkBox51, checkBox52, checkBox53, checkBox54, checkBox55, checkBox56, checkBox57, checkBox58, checkBox59, checkBox60, checkBox61, checkBox62, checkBox63, checkBox64, checkBox65, checkBox66, checkBox67, checkBox68, checkBox69, checkBox70, checkBox71, checkBox72, checkBox73, checkBox74, checkBox75, checkBox76, checkBox77, checkBox78, checkBox79, checkBox80, checkBox81, checkBox82, checkBox83, checkBox84, checkBox85, checkBox86, checkBox87, checkBox88, checkBox89, checkBox90, checkBox91, checkBox92, checkBox93, checkBox94, checkBox95, checkBox96, checkBox97, checkBox98, checkBox99, checkBox100, checkBox101, checkBox102, checkBox103, checkBox104, checkBox105, checkBox106, checkBox107, checkBox108, checkBox109, checkBox110, checkBox111, checkBox112, checkBox113, checkBox114, checkBox115, checkBox116, checkBox117, checkBox118, checkBox119, checkBox120, checkBox121, checkBox122, checkBox123, checkBox124, checkBox125, checkBox126, checkBox127, checkBox128, checkBox129, checkBox130, checkBox131, checkBox132, checkBox133, checkBox134, checkBox135, checkBox136, checkBox137, checkBox138, checkBox139, checkBox140, checkBox141, checkBox142, checkBox143, checkBox144, checkBox145, checkBox146, checkBox147, checkBox148, checkBox149, checkBox150, };
            int i = 30;

            foreach (CheckBox item in checkArray)
            {
                if (item.IsChecked == true) 
                {
                    safe[i] = "true";
                }
                else
                {
                    safe[i] = "false";
                }
                i++;
            }

            string[] old = new string[0];
            string[] save = new string[safe.Length];

            try
            {
                old = File.ReadAllLines("seite5.txt");
                save = new string[amount * 180 + safe.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten Daten Vorhanden!" + ex);
            }

            i = 0;

            for (int j = 0; j < amount * 180; j++)
            {
                save[i] = old[i];
                i++;
            }
            foreach (string item in safe)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite5.txt", save);

            seite6 s6 = new seite6();
            s6.Show();

            this.Close();
        }

        private void speichern_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(File.ReadAllText("amount.txt"));
            string[] safe = new string[180];

            safe[0] = zeit1.Text;
            safe[1] = zeit2.Text;
            safe[2] = zeit3.Text;
            safe[3] = zeit4.Text;
            safe[4] = zeit5.Text;
            safe[5] = zeit6.Text;
            safe[6] = zeit7.Text;
            safe[7] = zeit8.Text;
            safe[8] = zeit9.Text;
            safe[9] = zeit10.Text;
            safe[10] = zeit11.Text;
            safe[11] = zeit12.Text;
            safe[12] = zeit13.Text;
            safe[13] = zeit14.Text;
            safe[14] = zeit15.Text;

            safe[15] = ergebnis1.Text;
            safe[16] = ergebnis2.Text;
            safe[17] = ergebnis3.Text;
            safe[18] = ergebnis4.Text;
            safe[19] = ergebnis5.Text;
            safe[20] = ergebnis6.Text;
            safe[21] = ergebnis7.Text;
            safe[22] = ergebnis8.Text;
            safe[23] = ergebnis9.Text;
            safe[24] = ergebnis10.Text;
            safe[25] = ergebnis11.Text;
            safe[26] = ergebnis12.Text;
            safe[27] = ergebnis13.Text;
            safe[28] = ergebnis14.Text;
            safe[29] = ergebnis15.Text;

            CheckBox[] checkArray = new CheckBox[150] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24, checkBox25, checkBox26, checkBox27, checkBox28, checkBox29, checkBox30, checkBox31, checkBox32, checkBox33, checkBox34, checkBox35, checkBox36, checkBox37, checkBox38, checkBox39, checkBox40, checkBox41, checkBox42, checkBox43, checkBox44, checkBox45, checkBox46, checkBox47, checkBox48, checkBox49, checkBox50, checkBox51, checkBox52, checkBox53, checkBox54, checkBox55, checkBox56, checkBox57, checkBox58, checkBox59, checkBox60, checkBox61, checkBox62, checkBox63, checkBox64, checkBox65, checkBox66, checkBox67, checkBox68, checkBox69, checkBox70, checkBox71, checkBox72, checkBox73, checkBox74, checkBox75, checkBox76, checkBox77, checkBox78, checkBox79, checkBox80, checkBox81, checkBox82, checkBox83, checkBox84, checkBox85, checkBox86, checkBox87, checkBox88, checkBox89, checkBox90, checkBox91, checkBox92, checkBox93, checkBox94, checkBox95, checkBox96, checkBox97, checkBox98, checkBox99, checkBox100, checkBox101, checkBox102, checkBox103, checkBox104, checkBox105, checkBox106, checkBox107, checkBox108, checkBox109, checkBox110, checkBox111, checkBox112, checkBox113, checkBox114, checkBox115, checkBox116, checkBox117, checkBox118, checkBox119, checkBox120, checkBox121, checkBox122, checkBox123, checkBox124, checkBox125, checkBox126, checkBox127, checkBox128, checkBox129, checkBox130, checkBox131, checkBox132, checkBox133, checkBox134, checkBox135, checkBox136, checkBox137, checkBox138, checkBox139, checkBox140, checkBox141, checkBox142, checkBox143, checkBox144, checkBox145, checkBox146, checkBox147, checkBox148, checkBox149, checkBox150, };
            int i = 30;

            foreach (CheckBox item in checkArray)
            {
                if (item.IsChecked == true)
                {
                    safe[i] = "true";
                }
                else
                {
                    safe[i] = "false";
                }
                i++;
            }

            string[] old = new string[0];
            string[] save = new string[safe.Length];

            try
            {
                old = File.ReadAllLines("seite5.txt");
                save = new string[amount * 180 + safe.Length];
            }
            catch (IOException ex)
            {
                MessageBox.Show("Keine alten Daten Vorhanden!" + ex);
            }

            i = 0;

            for (int j = 0; j < amount * 180; j++)
            {
                save[i] = old[i];
                i++;
            }
            foreach (string item in safe)
            {
                save[i] = item;
                i++;
            }

            File.WriteAllLines("seite5.txt", save);
        }

        private void strategie1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void zeit1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
