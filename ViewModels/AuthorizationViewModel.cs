using DemoProjectWPF_Zagidullin_Syacterev_4435.Infrastructure.Commands;
using DemoProjectWPF_Zagidullin_Syacterev_4435.Infrastructure.Stores;
using DemoProjectWPF_Zagidullin_Syacterev_4435.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoProjectWPF_Zagidullin_Syacterev_4435.ViewModels
{
    class AuthorizationViewModel : ViewModelBase
    {
        public AuthorizationViewModel()
        {
            ToMainMenuPageCommand = new LambdaCommand(OnToMainMenuPageCommand);
        }
        #region Команды

        #region Команда перехода на тестовую страницу

        public ICommand ToMainMenuPageCommand { get;  }

        private void OnToMainMenuPageCommand(object parameter)
        {
            NavigationStore navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new MainMenuPageViewModel();

            MainWindow window = new MainWindow()
            {
                DataContext = new MainWindowViewModel(navigationStore)
            };
            window.Show();
        }

        #endregion

        #endregion
    }
}
