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
    public partial class BooksCatalogPage : ContentPage
    {
        public List<Book> Books { get; set; }

        public BooksCatalogPage()
        {
            InitializeComponent();
            Books = App.Db.GetBooks();
            BindingContext = this;
        }

        private void LVBooks_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}