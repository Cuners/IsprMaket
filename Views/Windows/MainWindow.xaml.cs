using DemoProjectWPF_Zagidullin_Syacterev_4435.Infrastructure.Stores;
using DemoProjectWPF_Zagidullin_Syacterev_4435.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoProjectWPF_Zagidullin_Syacterev_4435.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationStore navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new AuthorizationViewModel();
            DataContext = new MainWindowViewModel(navigationStore);
        }
    }
}
