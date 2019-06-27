using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.OutBackX.View;

namespace XF.OutBackX.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageMaster : ContentPage
	{
        public ListView ListaMenu { get { return lstMenu; } }
		public MainPageMaster ()
		{
			InitializeComponent ();
            InicializarItensDeMenu();
		}

        private void InicializarItensDeMenu()
        {
            ObservableCollection<MainPageMenuItem> itensDeMenu = new ObservableCollection<MainPageMenuItem>();
            itensDeMenu.Add(new MainPageMenuItem()
            {
                Descricao = "Home",
                TargetType = typeof(MainPage)
            });

            itensDeMenu.Add(new MainPageMenuItem()
            {
                Descricao = "Login",
                TargetType = typeof(LoginPage)
            });

            lstMenu.ItemsSource = itensDeMenu;
        }
    }
}