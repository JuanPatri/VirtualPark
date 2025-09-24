using VirtualPark.BusinessLogic.Users.Entity;
using VirtualPark.BusinessLogic.Users.Models;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.Users.Service;

public class UserService(IRepository<User> userRepository)
{
    private readonly IRepository<User> _userRepository = userRepository;

    public Guid Create(UserArgs args)
    {
        if(_userRepository.Exist(u => u.Email == args.Email))
        {
            throw new InvalidOperationException("Email already exists");
        }

        var user = new User
        {
            Name = args.Name,
            LastName = args.LastName,
            Email = args.Email,
            Password = args.Password,

            // hacer craete de visitor profile
            // y rolelist
        };

        _userRepository.Add(user);
        return user.Id;
    }
}
