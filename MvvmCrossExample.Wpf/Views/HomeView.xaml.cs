using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using MvvmCrossExample.Core.ViewModels;

namespace MvvmCrossExample.Wpf.Views
{
    [MvxViewFor(typeof(HomeViewModel))]
    public partial class HomeView : MvxWpfView
    {
        public HomeView()
        {
            InitializeComponent();
        }
    }
}
