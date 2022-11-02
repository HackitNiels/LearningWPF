using LearningWPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWPF.MVVM.ViewModel
{
    public class HomeViewModel : ObservableObject, IViewModel
    {
        private bool _isActive;
        public string Name => "Home";

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
