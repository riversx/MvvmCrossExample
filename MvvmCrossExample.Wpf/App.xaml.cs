using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;
using Bugsnag;
using System.Windows;

namespace MvvmCrossExample.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        private static Client BugSnag;

        public App()
        {
            this.RegisterSetupType<MvxWpfSetup<Core.App>>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            BugSnag = new Client(new Configuration("62f35faf0de664259e3eda1cfdd8302d"));
        }
    }
}
