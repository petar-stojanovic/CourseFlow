using System.Security.Claims;
using CourseFlow.Models;
using CourseFlow.Repository.UserRepository;

namespace CourseFlow.Services.UserService;

public class UserService : IUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IUserRepository _userRepository;

    public UserService(IHttpContextAccessor httpContextAccessor, IUserRepository userRepository)
    {
        _httpContextAccessor = httpContextAccessor;
        this._userRepository = userRepository;
    }

    public string GetUsername()
    {
        var result = string.Empty;
        if (_httpContextAccessor.HttpContext != null)
        {
            result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
        }

        return result;
    }

    public User AddUser(User user)
    {
        _userRepository.AddUser(user);
        return user;
    }
}