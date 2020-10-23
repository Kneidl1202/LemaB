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
    /// Interaktionslogik für Seite8.xaml
    /// </summary>
    public partial class Seite8 : Window
    {
        public Seite8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            seite9 s9 = new seite9();
            s9.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            seite6 s6 = new seite6();
            s6.Show();
            this.Close();
        }

        //von einem Stick laden
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "Von wo sollen die Daten kopiert werden?";
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            ReadFilesFromFlashDrive(Convert.ToString(result));
        }
        

        //auf einen Stick laden
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "Waehlen Sie den Speicherort aus";
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            CopyFilesToFlashDrive(Convert.ToString(result));
        }

        void CopyFilesToFlashDrive(string savePath)
        {
            string[] files = new string[8] { "amount.txt", "seite1.txt", "seite2checkboxes.txt", "seite2textboxes.txt", "seite3.txt", "seite4.txt", "seite5.txt", "seite6.txt" };

            try
            {
                foreach (string item in files)
                {
                    File.Move(item, savePath + "/" + item);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        void ReadFilesFromFlashDrive(string readPath)
        {
            Console.WriteLine("Sind Sie sicher, dass Sie die bereits existierenden Daten Überschreiben wollen? Wenn ja geben Sie ja ein und drücken Enter. Sonst drücken Sie eine beliebige Taste.");
            if (Console.ReadLine() == "ja")
            {
                string[] files = new string[8] { "amount.txt", "seite1.txt", "seite2checkboxes.txt", "seite2textboxes.txt", "seite3.txt", "seite4.txt", "seite5.txt", "seite6.txt" };

                try
                {
                    foreach (string item in files)
                    {
                        File.Move(readPath + "/" + item, item);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
            else
            {
                Console.WriteLine("Der Überschreibvorgang wurde abgebrochen.");
            }
        }
    }
}
