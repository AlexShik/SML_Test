using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using GitUsers_MasterDetail.Model;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows.Controls;


namespace GitUsers_MasterDetail.ViewModel
{
    public class UserMasterPageViewModel : ViewModelBase
    {
        public UserMasterPageViewModel()
        {
        }

        ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get
            {
                if (_users == null)
                    _users = UserRepository.AllUsers;
                return _users;
            }
        }
        public User SelectedItem { get; set; }

        //Show UserDetailPage
        RelayCommand _showDetailCommand;
        public ICommand ShowDetail
        {
            get
            {
                if (_showDetailCommand == null)
                    _showDetailCommand = new RelayCommand(ExecuteShowDetailCommand, CanExecuteAddClientCommand);
                return _showDetailCommand;
            }
        }

        public bool CanExecuteAddClientCommand()
        {
            if (SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        public void ExecuteShowDetailCommand()
        {
            UserRepository.RequestForUser(SelectedItem);
            ViewModelLocator.DetailPageViewModel.RefreshData();
            ViewModelLocator.Main.MainFrame.Navigate(ViewModelLocator.Main.UserDetailPage);
        }
    }
}
