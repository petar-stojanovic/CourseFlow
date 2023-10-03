using CourseFlow.Models;

namespace CourseFlow.Repository.UserRepository;

public interface IUserRepository
{
    void AddUser(User user);
    User GetUser(Guid id);
    User getUserByUsername(string username);
    bool UserExists(string username);
    User UpdateUser(User user);
    User getUserByToken(string token);
    List<User> GetAllUsers();
}