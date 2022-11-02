using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningWPF.Core
{
    public class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        //private Func<object, bool> _canExecute;
        readonly Predicate<object> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        //public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        //{
        //    _execute = execute;
        //    _canExecute = canExecute;
        //}

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

    }
}
