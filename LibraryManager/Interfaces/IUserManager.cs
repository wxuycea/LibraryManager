using LibraryManager.Model;

namespace LibraryManager.Interfaces {
    public interface IUserManager {
        public void AddUser(User user);
        public void UpdateUser(User user);
        public void RemoveUser(int userId);
        public User FindUserById(int userId);
    }
}
