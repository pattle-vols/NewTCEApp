using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewTCEApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        /*
		async void itemSelect(object sender, SelectedItemChangedEventArgs e)
		{
			//var item = (Event)e.SelectedItem;
			var item = e.SelectedItem as Event;
			await Navigation.PushAsync(new DetailsPage(item.Url));
		}
		*/
    }
}