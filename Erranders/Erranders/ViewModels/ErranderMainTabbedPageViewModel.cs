using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Erranders.ViewModels
{
	public class ErranderMainTabbedPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;

        private DelegateCommand _contactUsCommand;
        private DelegateCommand _editProfileCommand;
        private DelegateCommand _changePaymentCommand;
        private DelegateCommand _signOutCommand;

        public DelegateCommand ContactUsCommand => _contactUsCommand ?? (_contactUsCommand = new DelegateCommand(ExecuteContactUsCommand));
        public DelegateCommand EditProfileCommand => _editProfileCommand ?? (_editProfileCommand = new DelegateCommand(ExecuteEditProfileCommand));
        public DelegateCommand ChangePaymentCommand => _changePaymentCommand ?? (_changePaymentCommand = new DelegateCommand(ExecuteChangePaymentCommand));
        public DelegateCommand SignOutCommand => _signOutCommand ?? (_signOutCommand = new DelegateCommand(ExecuteSignOutCommand));
        public ErranderMainTabbedPageViewModel(IPageDialogService pageDialogService, INavigationService navigationService)
        {
            _pageDialogService = pageDialogService;
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }
        private void ExecuteContactUsCommand()
        {

        }

        private async void ExecuteEditProfileCommand()
        {
            await _navigationService.NavigateAsync("ErranderEditProfilePage");
        }

        private void ExecuteChangePaymentCommand()
        {

        }

        private async void ExecuteSignOutCommand()
        {
            bool choice = await _pageDialogService.DisplayAlertAsync("Notice", "Continue to Sign out?", "Yes", "No");
            if (choice)
            {
                await _navigationService.GoBackToRootAsync();
            }
        }
    }
}
