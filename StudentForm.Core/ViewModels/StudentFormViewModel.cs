using MvvmCross.ViewModels;
using StudentForm.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm.Core.ViewModels
{
    public class StudentFormViewModel : MvxViewModel
    {
        private readonly ICalculatorService _calculatorService;
        private double _a;
        private double _b;
        private double _c;
        private double _x1;
        private double _x2;

        public StudentFormViewModel(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public double a
        {
            get => _a;
            set
            {
                _a = value;
                RaisePropertyChanged(() => a);
                Recalculate();
            }
        }

        public double b
        {
            get => _b;
            set
            {
                _b = value;
                RaisePropertyChanged(() => b);
                Recalculate();
            }
        }

        public double c
        {
            get => _c;
            set
            {
                _c = value;
                RaisePropertyChanged(() => c);
                Recalculate();
            }
        }
        public double x1
        {
            get => _x1;
            set
            {
                _x1 = value;
                RaisePropertyChanged(() => _x1);
                Recalculate();
            }
        }

        public double x2
        {
            get => _x2;
            set
            {
                _x2 = value;
                RaisePropertyChanged(() => _x2);
                Recalculate();
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();

            x1 = 0;
            x2 = 0;
            a = 1;
            b = 1;
            c = 1;
            Recalculate();

        }

        private void Recalculate()
        {
            x1 = _calculatorService.StudentFormValues(x1,x1,a,b,c);
        }
    }
}
