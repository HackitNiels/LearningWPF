using LearningWPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWPF.MVVM.ViewModel
{
    public class AccountViewModel : ObservableObject, IViewModel
    {
        private bool _isActive;
        public string Name => "Account";

        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
                OnPropertyChanged("IsActive");
            }
        }
    }
}
