using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamlTipsTricks.ViewModels
{
    public class MainPageViewModel
    {
        INavigationService _navigationService;

        public DelegateCommand LoginCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            LoginCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync($"{NavConstants.Navigation}/{NavConstants.Home}");
            });
        }
    }
}
