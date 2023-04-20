using NewTCEApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NewTCEApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}