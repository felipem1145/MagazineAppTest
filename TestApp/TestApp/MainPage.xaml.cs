using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TestApp.Models;
using Xamarin.Essentials;

namespace TestApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage 
    {


        public IList<Edition> Editions { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            Editions = new List<Edition>();
            Editions.Add(new Edition
            {
                Name = "Issue 01",
                Date = "June 2021",
                ImageUrl = "JuneCover"

            });

            BindingContext = this;

            
        }

        private async void ShowMagazine(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewerPage());
        }

        private async void GoWebsite(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.culturallyarts.com");
        }



    }
}
