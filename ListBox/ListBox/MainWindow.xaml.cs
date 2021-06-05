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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Student> students=new List<Student>();
            students.Add(new Student() {Name="HJ",Age=22,Gender="Male" });
            students.Add(new Student() { Name = "DJ", Age = 22, Gender = "Male" });
            students.Add(new Student() { Name = "CJ", Age = 22, Gender = "Male" });
            students.Add(new Student() { Name = "PJ", Age = 22, Gender = "Male" });
            Stuinfo.ItemsSource = students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Stuinfo.SelectedItem != null) {
                var data = Stuinfo.SelectedItem;
                MessageBox.Show("Name:"+ (data as Student).Name +
                    "Age :" + (data as Student).Age +
                    "Gender"+(data as Student).Gender
                    );
            }  
        }
    }
    public class Student {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
