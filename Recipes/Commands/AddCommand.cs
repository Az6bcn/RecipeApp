using System;
using System.Windows.Input;

namespace Recipes.Commands
{
    public class AddCommand: ICommand
    {
        public AddCommand()
        {
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
