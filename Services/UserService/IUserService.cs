using CourseFlow.Models.User;

namespace CourseFlow.Services.UserService;

public interface IUserService
{
    string GetUsername();
    User AddUser(User user);
}