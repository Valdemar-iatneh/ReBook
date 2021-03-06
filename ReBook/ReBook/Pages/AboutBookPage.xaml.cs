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
        private double rate;
        private double sum;
        public AboutBookPage()
        {
            InitializeComponent();
            if (App.Db.GetReviews().Where(a => a.IdBook == BooksCatalogPage.book.Id).Count() != 0)
            {
                foreach (var review in App.Db.GetReviews().Where(a => a.IdBook == BooksCatalogPage.book.Id))
                {
                    sum += (review.Rank);
                }
                rate = Math.Round(sum / (App.Db.GetReviews()
                    .Where(a => a.IdBook == BooksCatalogPage.book.Id).Count()),2);
                Rating.Text = rate.ToString();
                BindingContext = this;
            }
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
            Navigation.PushAsync(new developers());

        }
    }
}