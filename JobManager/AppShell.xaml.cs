﻿//using JobManager.ViewModels;

using JobManager.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace JobManager
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(WelcomePage), typeof(WelcomePage));
           // Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

       /* private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        } */
    }
}
