using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvmCrossExample.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        public override void Prepare()
        {
            // This is the first method to be called after construction
            base.Prepare();
        }

        public override Task Initialize()
        {
            // Async initialization, YEY!
            return base.Initialize();
        }

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}