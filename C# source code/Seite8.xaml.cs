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
using System.Windows.Forms;

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

            ReadFilesFromFlashDrive(dialog.SelectedPath);
        }
        

        //auf einen Stick laden
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "Waehlen Sie den Speicherort aus";
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            CopyFilesToFlashDrive(dialog.SelectedPath);
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
            if (System.Windows.MessageBox.Show("", "Sicher, dass die Daten Daten im Originalspeicherort ueberschrieben werden sollen?", (MessageBoxButton)MessageBoxButtons.YesNo) == MessageBoxResult.Yes)
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
                System.Windows.MessageBox.Show("Der Überschreibvorgang wurde abgebrochen.");
            }
        }
    }
}
