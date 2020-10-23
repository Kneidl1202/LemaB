using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace LeMa_A
{
    /// <summary>
    /// Interaktionslogik für seite9.xaml
    /// </summary>
    public partial class seite9 : Window
    {
        private string[] nameArray = new string[2];

        public seite9()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] read = new string[0];
            int positionChild = 0;
            bool exists = false;

            try
            {
                read = File.ReadAllLines("seite1.txt");
            }
            catch (IOException ex)
            {
                MessageBox.Show("No entries found!" + ex);
            }

            for (int i = 3; i < read.Length; i += 8)
            {
                string[] nameSplit = read[i - 1].Split(' ');

                if (nameSplit[0] == nameArray[0])
                {
                    exists = true;
                    positionChild = i / 8;
                    break;
                }
                else if (nameArray[1] == nameSplit[0])
                {
                    exists = true;
                    positionChild = i / 8;
                    break;
                }
                else if (nameSplit[1] == nameArray[0])
                {
                    exists = true;
                    positionChild = i / 8;
                    break;
                }
                else if (nameArray[1] == nameSplit[1])
                {
                    exists = true;
                    positionChild = i / 8;
                    break;
                }
            }
            if (exists == false)
            {
                MessageBox.Show("Dieser Schüler existiert nicht. Geben Sie einen anderen Namen ein!");
            }
            else
            {
                string[] files = new string[7] { "seite1.txt", "seite2checkboxes.txt", "seite2textboxes.txt", "seite3.txt", "seite4.txt", "seite5.txt", "seite6.txt"};
                int[] lengths = new int[7] { 8, 8, 18, 24, 14, 45, 9};
                int i = 0;

                foreach (string item in files)
                {
                    read = File.ReadAllLines(item);
                    string[] tempSave = new string[lengths[i]];
                    int k = 0;
                    for(int j = 0; j < lengths[i]; j++)
                    {
                        tempSave[j] = read[(positionChild * lengths[i]) + j];
                    }

                    string[] save = new string[read.Length];

                    for (int j = 0; j < positionChild * lengths[i]; j++)
                    {
                        save[k] = read[j];
                        k++;
                    }
                    for (int j = positionChild * lengths[i] + lengths[i]; j < read.Length; j++)
                    {
                        save[k] = read[j];
                        k++;
                    }

                    for (int j = 0; j < tempSave.Length; j++)
                    {
                        save[k] = tempSave[j];
                        k++;
                    }

                    File.WriteAllLines(files[i], save);
                    i++;
                }

                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
        }

        private void Vorname_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = Vorname.Text;
            nameArray[0] = name;
        }

        private void Nachname_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = Nachname.Text;
            nameArray[1] = name;
        }
    }




}
