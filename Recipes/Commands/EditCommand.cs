using System;
using System.Windows.Input;

namespace Recipes.Commands
{
    public class EditCommand: ICommand
    {
        public EditCommand()
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
