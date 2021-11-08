using GitHubActionsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubActionsTest.ViewModels
{
    class MainViewModel : NotificationObject
    {
        private int _leftValue = 0;
        public int LeftValue
        {
            get { return _leftValue; }
            set { SetProperty(ref _leftValue, value); }
        }

        private int _rightValue = 0;
        public int RightValue
        {
            get { return _rightValue; }
            set { SetProperty(ref _rightValue, value); }
        }

        private int _resultValue = 0;
        public int ResultValue
        {
            get { return _resultValue; }
            set { SetProperty(ref _resultValue, value); }
        }

        private readonly DelegateCommand _calcRunCommand;
        public DelegateCommand CalcRunCommand { get => _calcRunCommand; }

        private int _arithmeticOperationsIndex = 0;
        public int ArithmeticOperationsIndex
        {
            get { return _arithmeticOperationsIndex; }
            set { SetProperty(ref _arithmeticOperationsIndex, value); }
        }
        public KeyValuePair<int, string> ArithmeticOperationsItem { get; set; }
        public Dictionary<int, string> _arithmeticOperations = new Dictionary<int, string>()
        {
            { 0, "＋" },
            { 1, "－" },
            { 2, "×" },
            { 3, "÷" },
        };
        public Dictionary<int, string> ArithmeticOperations { get { return _arithmeticOperations; } }

        public MainViewModel()
        {
            _calcRunCommand = new DelegateCommand(
                _ => {
                    Calculator calc = new Calculator();
                    if (ArithmeticOperationsIndex == 0) ResultValue = calc.Add(LeftValue, ResultValue);
                    else if (ArithmeticOperationsIndex == 1) ResultValue = calc.Sub(LeftValue, ResultValue);
                    else if (ArithmeticOperationsIndex == 2) ResultValue = calc.Mul(LeftValue, ResultValue);
                    else if (ArithmeticOperationsIndex == 3) ResultValue = calc.Div(LeftValue, ResultValue);
                });
        }
    }
}
