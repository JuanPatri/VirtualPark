using VirtualPark.BusinessLogic.Roles.Entity;
using VirtualPark.BusinessLogic.Users.Entity;
using VirtualPark.BusinessLogic.Users.Models;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.Users.Service;

public class UserService(IRepository<User> userRepository, IReadOnlyRepository<Role> rolesRepository)
{
    private readonly IRepository<User> _userRepository = userRepository;
    private readonly IReadOnlyRepository<Role> _rolesRepository = rolesRepository;

    public Guid Create(UserArgs args)
    {
        ValidateEmail(args);

        var user = MapToEntity(args);

        _userRepository.Add(user);
        return user.Id;
    }

    private void ValidateEmail(UserArgs args)
    {
        var isEmailTaken = _userRepository.Exist(u => u.Email == args.Email);
        if(isEmailTaken)
        {
            throw new InvalidOperationException("Email already exists");
        }
    }

    private User MapToEntity(UserArgs args) => new User
    {
        Name = args.Name,
        LastName = args.LastName,
        Email = args.Email,
        Password = args.Password,
        Roles = GetRolesFromIds(args.RolesIds)
    };

    private List<Role> GetRolesFromIds(List<Guid> roleIds)
    {
        var roles = new List<Role>();

        foreach (var roleId in roleIds)
        {
            var role = _rolesRepository.Get(r => r.Id == roleId);
            if (role is null)
            {
                throw new InvalidOperationException($"Role with id {roleId} does not exist.");
            }

            roles.Add(role);
        }

        return roles;
    }
}
