using System;
using System.Threading.Tasks;
using WSTowerApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerApp
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetail { get; set;}

        public async static Task NavigationMasterDetail(Page page)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.Detail.Navigation.PushAsync(page);
        }
        public App()
        {
            InitializeComponent();

            MainPage = new Splash();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
