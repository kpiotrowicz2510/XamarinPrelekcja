using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinPrelekcja
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            
        }

        public async Task WyswietlAlert(string text)
        {
            await DisplayAlert("Alert", text, "Cancel");
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MasterPage(), true);
            //await WyswietlAlert("Hello!");
        }
    }
}
