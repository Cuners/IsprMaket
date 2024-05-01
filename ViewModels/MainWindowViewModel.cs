using DemoProjectWPF_Zagidullin_Syacterev_4435.Infrastructure.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectWPF_Zagidullin_Syacterev_4435.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public readonly NavigationStore _navigationStore;
        public MainWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
