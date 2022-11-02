using LearningWPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningWPF.MVVM.ViewModel
{
    public class ApplicationViewModel : ObservableObject
    {
        private ICommand _changeViewCommand;

        private IViewModel _CurrentViewModel;
        private List<IViewModel> _viewModels;
        private bool _isActive;

        public ApplicationViewModel()
        {
            ViewModels.Add(new HomeViewModel());
            ViewModels.Add(new AccountViewModel());

            CurrentViewModel = ViewModels.Find(r => r.Name == "Home");
            CurrentViewModel.IsActive = true;
        }

        public List<IViewModel> ViewModels
        {
            get
            {
                if (_viewModels == null)
                    _viewModels = new List<IViewModel>();

                return _viewModels;
            }
        }

        public IViewModel CurrentViewModel
        {
            get
            {
                return _CurrentViewModel;
            }
            set
            {
                if (_CurrentViewModel != value)
                {
                    _CurrentViewModel = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changeViewCommand == null)
                {
                    _changeViewCommand = new RelayCommand(
                        p => ChangeViewModel((IViewModel)p),
                        p => p is IViewModel);
                }

                return _changeViewCommand;
            }
        }
       

        private void ChangeViewModel(IViewModel viewModel)
        {
            CurrentViewModel = ViewModels.Find(r => r.Name == viewModel.Name);
        }

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
