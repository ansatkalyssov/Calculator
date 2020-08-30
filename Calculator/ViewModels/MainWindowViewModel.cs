using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {

        private string _synchronizedText;
        public string SynchronizedText
        {
            get => _synchronizedText;
            set
            {
                _synchronizedText = value;
                OnPropertyChanged(nameof(SynchronizedText));
            }
        }
    }
}
