using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ReBook.Data;

namespace ReBook.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutBookPage : ContentPage
    {
        public AboutBookPage()
        {
            InitializeComponent();
            
            BindingContext = this;
        }

        private void BtnAddComment_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddReviewPage());
        }


        private void Reviews_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReviewsPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Db.DeleteItem();
        }
    }
}