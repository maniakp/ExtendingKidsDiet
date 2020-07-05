using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExtendingKidsDiet.Const;
using ExtendingKidsDiet.ViewModels;
using ExtendingKidsDiet.Views;
using Prism.Ioc;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ExtendingKidsDiet
{
    public partial class App 
    {
        public App()
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            var result = await NavigationService.NavigateAsync("MainPage");

            if(!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start($"android={AppSecrets.AppCenterAndroidSecret};" +
                            $"ios={AppSecrets.AppCenterIosSecret}",
                typeof(Analytics), typeof(Crashes));
        }
        
        


        
    }
}