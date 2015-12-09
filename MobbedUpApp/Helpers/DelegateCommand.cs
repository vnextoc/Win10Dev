using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobbedUpApp {
    public class DelegateCommand : System.Windows.Input.ICommand {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action execute) : this(execute, () => true) { }

        public DelegateCommand(Action execute, Func<bool> canExecute) {
            if( execute == null ) throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object p) {
            return _canExecute == null ? true : _canExecute();
        }

        public void Execute(object p) {
            if( CanExecute(null) ) _execute();
        }

        public void RaiseExecuteChanged() {
            if( CanExecuteChanged != null ) CanExecuteChanged(this, EventArgs.Empty);
        }
    } //class DelegateCommand
}
