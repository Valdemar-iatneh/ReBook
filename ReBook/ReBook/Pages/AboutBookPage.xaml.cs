using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReBook.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutBookPage : ContentPage
    {
        public AboutBookPage()
        {
            InitializeComponent();
        }

        private void BtnAddComment_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddReviewPage());
        }
    }
}