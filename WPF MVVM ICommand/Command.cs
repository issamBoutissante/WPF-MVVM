using System;
using System.Windows.Input;

namespace WPF_MVVM_ICommand
{
    public class Command : ICommand
    {
        Action excecuteMethod;
        
        public Command(Action excecuteMethod)
        {
            this.excecuteMethod = excecuteMethod;
        }
        //this is the implemented method

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            excecuteMethod();
        }
        public event EventHandler CanExecuteChanged;
    }
}
