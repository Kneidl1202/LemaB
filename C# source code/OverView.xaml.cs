using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Interaktionslogik für OverView.xaml
    /// </summary>
    public partial class OverView : Window
    {
        public OverView()
        {
            InitializeComponent();
        }

        private void studentBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int amount = Convert.ToInt32(File.ReadAllText("amount.txt"));
            string[] mainText = File.ReadAllLines("seite1.txt");
            string[] names = new string[amount + 1];

            int j = 0;
            for(int i = 2; i < 8 * amount; i += 8)
            {
                names[j] = mainText[i];
            }

            foreach (string item in names)
            {
                studentBox.Items.Add(item);
            }
        }
    }
}
