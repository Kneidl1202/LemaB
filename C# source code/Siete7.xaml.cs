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
    /// Interaktionslogik für Siete7.xaml
    /// </summary>
    public partial class Siete7 : Window
    {
        public Siete7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Seite8 s8 = new Seite8();
            s8.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int amount = 0;

            try
            {
                amount = Convert.ToInt32(File.ReadAllText("amount.txt"));
            }
            catch (IOException ex)
            {
                Console.WriteLine("Fehler beim Lesen!!\n" + ex);
            }

            amount++;

            try
            {
                File.WriteAllText("amount.txt", Convert.ToString(amount));
            }
            catch (IOException ex)
            {
                Console.WriteLine("Fehler beim Speichern!!\n" + ex);
            }

            string[] placeCeeper = new string[] { "", "", "", "", "", "", "", "" };
            File.AppendAllLines("seite1.txt", placeCeeper); 
            placeCeeper = new string[] { "", "", "", "", "", "", "", "" };
            File.AppendAllLines("seite2checkboxes.txt", placeCeeper);
            placeCeeper = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            File.AppendAllLines("seite2textboxes.txt", placeCeeper);
            placeCeeper = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            File.AppendAllLines("seite3.txt", placeCeeper);
            placeCeeper = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            File.AppendAllLines("seite4.txt", placeCeeper);
            placeCeeper = new string[45];
            for (int i = 0; i < 45; i++)
            {
                placeCeeper[i] = "";
            }
            File.AppendAllLines("seite5.txt", placeCeeper);
            placeCeeper = new string[] { "", "", "", "", "", "", "", "", "" };
            File.AppendAllLines("seite6.txt", placeCeeper);

            MainWindow s1 = new MainWindow();
            s1.Show();

            this.Close();
        }
    }
}
