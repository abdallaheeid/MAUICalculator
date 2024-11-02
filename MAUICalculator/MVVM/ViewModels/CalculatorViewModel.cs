using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Dangl.Calculator;

using PropertyChanged;


namespace MAUICalculator.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {
        public string Formula {get; set; }

        public string Result { get; set; } = "0";

        public ICommand OperationCommand => new Command((number) =>
        {
            Formula += number;
        });

        public ICommand ResetCommand => new Command(() =>
        {
            Formula = string.Empty;
            Result = "0";
        });

        public ICommand BackSpaceCommand => new Command(() =>
        {
            if (Formula.Length > 0)
            {
                // Clear white space if it exists
                Formula = Formula.Substring(0, Formula.Length - 1);
            }
        });

        public ICommand CalcCommand => new Command(() =>
        {
            try
            {
                Result = Calculator.Calculate(Formula).Result.ToString();
            }
            catch (Exception)
            {
                Result = "Error";
            }
        });



    }
}
