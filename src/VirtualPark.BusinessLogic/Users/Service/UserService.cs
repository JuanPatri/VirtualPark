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

        return Guid.NewGuid();
    }
}
