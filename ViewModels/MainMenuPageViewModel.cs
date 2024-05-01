using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectWPF_Zagidullin_Syacterev_4435.ViewModels
{
    public class MainMenuPageViewModel: ViewModelBase
    {
        public ViewModelBase CurrentPage { get; set; }

        public MainMenuPageViewModel()
        {
            CurrentPage = new AbonentsViewModel();
        }
    }
}
