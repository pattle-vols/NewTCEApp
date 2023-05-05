using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewTCEApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SupportPage : ContentPage
    {
        public ICommand Contact => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand Resource => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand Dean => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand Counceling => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand Success => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand Orgs => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public SupportPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        
    }
}