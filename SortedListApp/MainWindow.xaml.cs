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

namespace SortedListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            //Add Data
            sortedList.Add(int.Parse(keyTxt.Text),valueTxt.Text);
            keyTxt.Text = "";
            valueTxt.Text = "";
            string Member = "";
            ICollection collection = sortedList.Keys;
            foreach(int key in collection)
            {
                Member = Member + sortedList[key] +"\n";
            }
            MessageBox.Show(Member);
            //Count
            MessageBox.Show("Number of Members: " +collection.Count.ToString());
        }
    }
}
