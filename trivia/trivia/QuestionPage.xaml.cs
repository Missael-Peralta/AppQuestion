using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trivia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage : ContentPage
    {
        public QuestionPage()
        {
            InitializeComponent();
        }

        private async void btnRes1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Message", "Wrong answer, please try again", "OK");
        }

        private async void btnRes2_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Message", "Correct answer", "OK");
        }

        private async void btnRes3_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Message", "Wrong answer, please try again", "OK");
        }
    }
}