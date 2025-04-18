using ScrumPulse.Models;

namespace ScrumPulse.Controller
{
    public class UserController
    {
        private List<User> users;

        public UserController()
        {
            users = new List<User>
            {
                new User { Username = "owner", Password = "1234", Rol = "Product Owner" },
                new User { Username = "scrum", Password = "1234", Rol = "Scrum Master" },
                new User { Username = "dev", Password = "1234", Rol = "Developer" }
            };
        }

        public User ValidateLogin(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
