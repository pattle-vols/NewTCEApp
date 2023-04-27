﻿using NewTCEApp.Views;
using System;
using Xamarin.Forms;

namespace NewTCEApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
			//Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			//Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
			Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
			Routing.RegisterRoute(nameof(EventsPage), typeof(EventsPage));
			Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
		}

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
