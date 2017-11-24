using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using GitUsers_MasterDetail.Model;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows.Controls;

namespace GitUsers_MasterDetail.ViewModel
{
    public class UserDetailPageViewModel : ViewModelBase
    {
        public UserDetailPageViewModel()
        {
        }

        User _currentUser;
        public User CurrentUser
        {
            get
            {
                //ask UserRepo for request to github api
                if (_currentUser == null)
                    _currentUser = UserRepository.CurrentUser;
                return _currentUser;
            }
            set
            {
                _currentUser = value;
                RaisePropertyChanged(() => CurrentUser);
            }
        }

        public void RefreshData()
        {
            CurrentUser = UserRepository.CurrentUser;
        }
    }
}
