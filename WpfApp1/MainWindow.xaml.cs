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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private int Item;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            ItemView.Items.Add(Item);
            Item++;
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            if (ItemView.SelectedItem == null) return;

            ItemView.Items.Remove(ItemView.SelectedItem);
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            ItemView.Items.Clear();
            Item = 0;
        }
    }
}
