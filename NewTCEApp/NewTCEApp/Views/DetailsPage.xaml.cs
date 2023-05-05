using NewTCEApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewTCEApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPage : ContentPage
	{
		static detail _detail = new detail();
		public static void InitPage(string title, string url, string location)
		{
			_detail.Title = title;
			_detail.Url = url;
			_detail.Location = location;
		}
		public DetailsPage()
		{
			InitializeComponent();
			BindingContext = _detail;
		}
	}
}