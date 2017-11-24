using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using RestSharp;
using System.Net;
using System.Web.Http;
using System.Windows;

namespace GitUsers_MasterDetail.Model
{
//Repository for user collection and current user.
    public class UserRepository
    {
        public UserRepository()
        {
        }

        private static User currentUser;
        public static User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                if (value.Email == null)
                    value.Email = "Empty";
                if (value.Name == null)
                    value.Name = "Empty";
                if (value.location == null)
                    value.location = "Empty";

                currentUser = value;
            }
        }
        
        //create user collection
        private static ObservableCollection<User> _users;
        public static ObservableCollection<User> AllUsers
        {
            get
            {
                if (_users == null)
                    _users = new ObservableCollection<User>();
                    addUsers();
                return _users;
            }
        }

        //request to github api for users list
        private static void addUsers()
        {
            var client = new RestClient("https://api.github.com/");
            var request = new RestRequest("users");

            var asyncHandle = client.ExecuteAsync<List<User>>(request, response =>
            {
                App.Current.Dispatcher.Invoke((Action)delegate
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        foreach (User user in response.Data)
                        {
                            _users.Add(user);
                        }
                    }
                    else
                    {
                        ConnectionProblem();
                    }
                });
            });

        }

        //request ti github api for single user
        public static void RequestForUser(User user)
        {
            try
            {
                var client = new RestClient("https://api.github.com/");
                var request = new RestRequest(string.Format("users/{0}", user.Login));
                var asyncHandle = client.ExecuteTaskAsync<User>(request).GetAwaiter().GetResult();
                CurrentUser = asyncHandle.Data;
            }
            catch
            {
                ConnectionProblem();
            }
        }

        //Bad response code handling.
        public static void ConnectionProblem()
        {
            MessageBox.Show("There is some problem with connection.");
            System.Environment.Exit(1);
        }
    }
}

        