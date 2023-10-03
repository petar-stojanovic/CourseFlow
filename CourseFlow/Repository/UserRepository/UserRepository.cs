using CourseFlow.Data;
using CourseFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseFlow.Repository.UserRepository;

public class UserRepository : IUserRepository
{
    private readonly DataContext _context;
    private DbSet<User> _users;

    public UserRepository(DataContext dataContext)
    {
        _context = dataContext;
        _users = dataContext.Set<User>();
    }


    public void AddUser(User user)
    {
        _users.Add(user);
        _context.SaveChanges();
    }

    public User GetUser(Guid id)
    {
        return _users.Where(user => user.Id == id).FirstOrDefault();
    }

    public User getUserByUsername(string username)
    {
        return _users.Where(x => x.Username == username).FirstOrDefault();
    }

    public bool UserExists(string username)
    {
        return _users.Any(u => u.Username == username);
    }

    public User UpdateUser(User user)
    {
        _users.Update(user);
        _context.SaveChanges();
        return user;
    }

    public User getUserByToken(string token)
    {
        return _users.Where(x => x.AuthToken == token).FirstOrDefault();
    }

    public List<User> GetAllUsers()
    {
        return _users.ToList();
    }
}