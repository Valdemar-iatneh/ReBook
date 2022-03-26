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
    public partial class AddReviewPage : ContentPage
    {
        private int _rank;
        public AddReviewPage()
        {
            InitializeComponent();
        }

        private void Rank5_Clicked(object sender, EventArgs e)
        {
            _rank = 5;
            Rank1.TextColor = Color.Red;
            Rank2.TextColor = Color.Red;
            Rank3.TextColor = Color.Red;
            Rank4.TextColor = Color.Red;
            Rank5.TextColor = Color.Red;
        }

        private void Rank4_Clicked(object sender, EventArgs e)
        {
            _rank = 4;
            Rank1.TextColor = Color.Red;
            Rank2.TextColor = Color.Red;
            Rank3.TextColor = Color.Red;
            Rank4.TextColor = Color.Red;
            Rank5.TextColor = Color.Gray;
        }

        private void Rank3_Clicked(object sender, EventArgs e)
        {
            _rank = 3;
            Rank1.TextColor = Color.Red;
            Rank2.TextColor = Color.Red;
            Rank3.TextColor = Color.Red;
            Rank4.TextColor = Color.Gray;
            Rank5.TextColor = Color.Gray;
        }

        private void Rank2_Clicked(object sender, EventArgs e)
        {
            _rank = 2;
            Rank1.TextColor = Color.Red;
            Rank2.TextColor = Color.Red;
            Rank3.TextColor = Color.Gray;
            Rank4.TextColor = Color.Gray;
            Rank5.TextColor = Color.Gray;
        }

        private void Rank1_Clicked(object sender, EventArgs e)
        {
            _rank = 1;
            Rank1.TextColor = Color.Red;
            Rank2.TextColor = Color.Gray;
            Rank3.TextColor = Color.Gray;
            Rank4.TextColor = Color.Gray;
            Rank5.TextColor = Color.Gray;
        }

        private async void BtnAddComment_Clicked(object sender, EventArgs e)
        {
            Review review = new Review();
            review.Author = AuthorName.Text;
            review.Comment = Comment.Text;
            review.Date = DateTime.Now.Date;
            review.Rank = _rank;
            review.IdBook = BooksCatalogPage.book.Id;
            //BooksCatalogPage.book = new Book();
            App.Db.SaveReview(review);
            await Navigation.PopAsync();
            //BooksCatalogPage.book.Reviews.Add(review);
        }
    }
}