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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           /*Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            WrapPanel wp = new WrapPanel();
            TextBlock t1 = new TextBlock();
            t1.Text = "Hello";
            t1.Foreground = Brushes.Red;
            TextBlock t2 = new TextBlock();
            t2.Text = "Hey there";
            t2.Foreground = Brushes.Green;
            wp.Children.Add(t1);
            wp.Children.Add(t2);
            btn.Content = wp;
            grid.Children.Add(btn); 
           */

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Direct Event
            MessageBox.Show("Hello Direct Event.....");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //Bubling Event dow to up
            MessageBox.Show("Hello Bubbling Event....");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {   //Tunneling event up to down 
            MessageBox.Show("Hello Tunneling Event....");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Tunneling event up to down 
            MessageBox.Show("Left Button Down....");
        }

        private void Button_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Right Button Down....");
        }
    }
}
