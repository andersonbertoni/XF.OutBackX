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
        public RestauranteViewModel RestauranteVM { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeViewModels();

            MainPage = new NavigationPage(new View.MainPage() { BindingContext = RestauranteVM });
        }

        private void InitializeViewModels()
        {
            this.LoginVM = new LoginViewModel();
            this.RestauranteVM = new RestauranteViewModel();
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
