using MvvmCross.Commands;
using MvvmCross.ViewModels;
using StudentForm.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentForm.Core.ViewModels
{
    public class StudentFormViewModel : MvxViewModel
    {
        private readonly ICalculatorService _calculatorService;
        private readonly ICalculatorYService _calculatorYService;
        private double _a;
        private double _b;
        private double _c;
        private double _x1;
        private double _x2;
        private MvxCommand _calculateCommand;

        public StudentFormViewModel(ICalculatorService calculatorService, ICalculatorYService calculatorYService)
        {
            _calculatorService = calculatorService;
            _calculatorYService = calculatorYService;
        }

        public double a
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }

        public double b
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }

        public double c
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }
        public double x1
        {
            get => _x1;
            set => SetProperty(ref _x1, value);
        }

        public double x2
        {
            get => _x2;
            set => SetProperty(ref _x2, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Recalculate);
                return _calculateCommand;
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
            x1 = _calculatorService.StudentFormValues(x1,x2,a,b,c);
            x2 = _calculatorYService.StudentFormValues(x1, x2, a, b, c);
        }
    }
}
