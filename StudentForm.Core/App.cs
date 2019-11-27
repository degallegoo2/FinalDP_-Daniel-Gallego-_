using MvvmCross.IoC;
using MvvmCross.ViewModels;
using StudentForm.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentForm.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                 .EndingWith("Service")
                 .AsInterfaces()
                 .RegisterAsLazySingleton();

            RegisterAppStart<StudentFormViewModel>();
        }

    }
}
