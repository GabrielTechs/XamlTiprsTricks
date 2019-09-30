using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamlTipsTricks.ViewModels
{
    public class HomePageViewModel
    {
        INavigationService _navigationService;

        public DelegateCommand InfoCommand { get; set; }
        public DelegateCommand TrappedCommand { get; set; }

        public HomePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            InfoCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync($"{NavConstants.Info}");
            });
            TrappedCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync($"{NavConstants.Trapped}");
            });
        }
    }
}
