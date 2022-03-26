using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReBook.Data;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReBook.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewsPage : ContentPage
    {
        public List<Review> Reviews { get; set; }
        public ReviewsPage()
        {
            InitializeComponent();
            Reviews = App.Db.GetReviews().Where(a => a.IdBook == BooksCatalogPage.book.Id).ToList();
            BindingContext = this;
        }

        private void BtnAddComment_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddReviewPage());
        }

        private async void UpdateView_Refreshing(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            UpdateList();
        }
        private void UpdateList()
        {
            LVreviews.ItemsSource = App.Db.GetReviews().Where(a => a.IdBook == BooksCatalogPage.book.Id).ToList(); ;
        }
    }
}