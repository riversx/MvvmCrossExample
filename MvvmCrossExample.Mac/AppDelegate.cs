using AppKit;
using Foundation;
using MvvmCross.Platforms.Mac.Core;

namespace MvvmCrossExample.Mac
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxMacSetup<Core.App>, Core.App>
    {
        public AppDelegate() { }

        public override void DidFinishLaunching(NSNotification notification)
        {
            MvxMacSetupSingleton.EnsureSingletonAvailable(this, MainWindow).EnsureInitialized();
            RunAppStart();
        }

    }
}
