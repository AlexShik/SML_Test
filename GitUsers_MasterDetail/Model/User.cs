
namespace GitUsers_MasterDetail.Model
{
    public class User
    {
        //Github user fields.
        public string Login { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string created_at { get; set; }
        public string location { get; set; }
        public string avatar_url { get; set; }

        public User()
        {
        }

        public User(string login, string id)
        {
            Login = login;
            Id = id;
        }

        public override string ToString()
        {
            return string.Format("id:{0} Login:{1}", Id, Login);
        }
    }
}
