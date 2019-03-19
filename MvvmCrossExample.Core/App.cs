using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCrossExample.Core.ViewModels;

namespace MvvmCrossExample.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<MainViewModel>();
        }
    }
}