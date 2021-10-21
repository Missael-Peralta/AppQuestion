using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace trivia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var name = txtName.Text;

            if (name == null)
            {
                await DisplayAlert("Message", "Enter a name", "OK");
            }
            else
            {
                await Navigation.PushAsync(new QuestionPage());
            }
        }
    }
}
