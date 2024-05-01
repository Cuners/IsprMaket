using DemoProjectWPF_Zagidullin_Syacterev_4435.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectWPF_Zagidullin_Syacterev_4435.Infrastructure.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged;

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrenViewModelChanged();
            }
        }

        private void OnCurrenViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
