﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace MVVM_WPF_Template.ViewModels
{
    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<object> OnExecute;
        private Predicate<object> OnCanExecute;

        public RelayCommand(Action<object> OnExecute, Predicate<object> OnCanExecute)
        {
            this.OnExecute = OnExecute;
            this.OnCanExecute = OnCanExecute;
        }
        public RelayCommand(Action<object> OnExecute)
        {
            this.OnExecute = OnExecute;
        }

        public bool CanExecute(object parameter)
        {
            return (OnCanExecute == null) ? true : OnCanExecute(parameter);
        }
        public void Execute(object parameter)
        {
            OnExecute?.Invoke(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
