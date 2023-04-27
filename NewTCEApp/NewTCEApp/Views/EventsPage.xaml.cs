using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NewTCEApp.Models;
using System;
using System.Diagnostics;
using NewTCEApp.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace NewTCEApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventsPage : ContentPage
	{
		public EventsPage()
		{
			InitializeComponent();
		}
	}
}