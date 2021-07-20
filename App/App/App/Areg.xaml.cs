using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Areg : ContentPage
    {
        bool load = false;
        public Areg()
        {
            InitializeComponent();
        }

        async private void BTN_Clicked(object sender, EventArgs e)
        {
            if (load == false)
            {
                //add loding list agent logic here
                ActivityIndicator activityIndicator = new ActivityIndicator { IsRunning = true };
                Parent.Children.Add(activityIndicator);           
                await Task.Delay(2000);
                activityIndicator.IsRunning = false;
                Parent.Children.Remove(activityIndicator);
                BTN.Text = "Submit";
                AgentList.IsVisible = true;
                load = true;
            }
            else { 
            
                // go to next page;
            }

        }
    }
}