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

namespace checkboxAndRadio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CBAll_Checked(object sender, RoutedEventArgs e)
        {
            bool isAllChecked = (CBAll.IsChecked==true);
            Mashroom.IsChecked = isAllChecked;
            Chilly.IsChecked = isAllChecked;
            Simla.IsChecked = isAllChecked; 
        }

        private void CBSingle_Checked(object sender, RoutedEventArgs e)
        {
            CBAll.IsChecked = null;
            if(Mashroom.IsChecked==true && Simla.IsChecked==true && Chilly.IsChecked == true) {
                CBAll.IsChecked = true;
            }
            if (Mashroom.IsChecked == false && Simla.IsChecked == false && Chilly.IsChecked == false)
            {
                CBAll.IsChecked = false;
            }
        }
    }
}
