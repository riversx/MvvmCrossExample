using System;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Mac.Views;
using MvvmCrossExample.Core.ViewModels;

namespace MvvmCrossExample.Mac
{
    [MvxFromStoryboard("Main")]
    public partial class ViewController : MvxViewController<MainViewModel>
    {
        public ViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<ViewController, MainViewModel>();
            set.Bind(TextField).To(vm => vm.Text);
            set.Bind(Button).To(vm => vm.ResetTextCommand);
            set.Apply();
        }

    }
}
