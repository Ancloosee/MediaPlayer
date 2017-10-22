using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VideoPlayer.Infasrtucture
{
    public class RelayCommand : ICommand
    {
     #region readonly field
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;
        #endregion

     #region property
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
     #endregion


    #region Constructors
        public RelayCommand(Action<object> executeAction):this(executeAction,null)
        {

        }
        public RelayCommand(Action<object> executeAction,Predicate<object> canExecute=null)
        {
            if (executeAction == null)
                throw new ArgumentException();
            _execute = executeAction;
            _canExecute = canExecute;
        }
    #endregion


        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
