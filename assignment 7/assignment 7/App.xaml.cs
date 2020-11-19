using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace assignment_7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            if (DesignMode.IsDesignModeEnabled)
            {
                return;
            }

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
