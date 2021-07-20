using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        string cur = "Agent";
        public MainPage()
        {
            InitializeComponent();
            
          
        }

         private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            
            if (Ctrl.IsChecked )
            {
                cur = "Controller";
                Img.Source= new EmbeddedResourceImageSource(new Uri("resource://App.Images.ctrl.svg"));
                Txt.Text = "A Controller phone shows location of agent.";
            }
            else {
                cur = "Agent";
                Img.Source = new EmbeddedResourceImageSource(new Uri("resource://App.Images.agent.svg"));
                
                Txt.Text = "Agent phone send their location to Controller phone.";
            }
        }

        private  async void Button_Clicked(object sender, EventArgs e)
        {
            if (Ctrl.IsChecked)
            {
                await Navigation.PushAsync(new Reg());
            }
            else {
                await Navigation.PushAsync(new Areg());
            }
           
        }
    }
}
