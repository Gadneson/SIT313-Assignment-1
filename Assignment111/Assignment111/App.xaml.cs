﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Assignment111
{
    public partial class App : Application
    {
        //Database String
        public static string DB_PATH = string.Empty;




        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        //SQLITE Setup
        public App(string DB_Path)
        {
            InitializeComponent();

            DB_PATH = DB_Path;

            MainPage = new NavigationPage(new MainPage());

        }




        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
