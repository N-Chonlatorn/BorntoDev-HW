using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HashtableApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            //Add
            hashtable.Add(keyTxt.Text,valueTxt.Text);
            keyTxt.Text = "";
            valueTxt.Text = "";
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            hashtable.Remove(keyTxt.Text);
            keyTxt.Text = "";
            valueTxt.Text = "";
        }

        private void ShowAllBtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            //Show All
            foreach(string key in icollection)
            {
                MessageBox.Show("Member :" +" " +hashtable[key].ToString());
            }

            //Count
            MessageBox.Show("Number of Members: "+icollection.Count.ToString());
        }
    }
}
