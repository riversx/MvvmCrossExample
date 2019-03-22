using AppKit;
using Bugsnag;

namespace MvvmCrossExample.Mac
{
    static class MainClass
    {
        private static Client BugSnag;

        static void Main(string[] args)
        {
            BugSnag = new Client(new Configuration("62f35faf0de664259e3eda1cfdd8302d"));
            NSApplication.Init();
            NSApplication.Main(args);
        }
    }

}
