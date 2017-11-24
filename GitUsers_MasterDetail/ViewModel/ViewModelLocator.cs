/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:GitUsers_MasterDetail"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace GitUsers_MasterDetail.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            //register ViewModels
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<UserMasterPageViewModel>();
            SimpleIoc.Default.Register<UserDetailPageViewModel>();
        }

        public static MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public static UserMasterPageViewModel MasterPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UserMasterPageViewModel>();
            }
        }

        public static UserDetailPageViewModel DetailPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UserDetailPageViewModel>();
            }
        }

        public static void Cleanup()
        {
        }
    }
}