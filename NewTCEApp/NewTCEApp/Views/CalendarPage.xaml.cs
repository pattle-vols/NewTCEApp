using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using NewTCEApp.ViewModels;

namespace NewTCEApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();
            BindingContext = new CalendarViewModel();
        }
    }
}
