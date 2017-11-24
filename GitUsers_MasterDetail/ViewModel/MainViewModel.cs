using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using GitUsers_MasterDetail.Model;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Diagnostics;
using System.Windows.Controls;
using System;

namespace GitUsers_MasterDetail.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {   
            masterPage = new UserMasterPage();
            userDetailPage = new UserDetailPage();
        }

        public Frame MainFrame { get; set; }
        public UserMasterPage masterPage;
        private UserDetailPage userDetailPage;
        public UserDetailPage UserDetailPage
        {
            get => userDetailPage;
            set => userDetailPage = value;
        }

        //MasterPage Navigation
        private ICommand loadedView_Command;
        public ICommand LoadedView_Command => loadedView_Command ??
                                              (loadedView_Command = new RelayCommand<Frame>(Loaded_Execute));

        private void Loaded_Execute(Frame frame)
        {
            MainFrame = frame;
            MainFrame.Navigate(masterPage);
        }
    }
}