using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.OutBackX.ViewModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XF.OutBackX
{
    public partial class App : Application
    {
        public LoginViewModel LoginVM { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeViewModels();

            MainPage = new NavigationPage(new View.MainPage());
        }

        private void InitializeViewModels()
        {
            this.LoginVM = new LoginViewModel();
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
