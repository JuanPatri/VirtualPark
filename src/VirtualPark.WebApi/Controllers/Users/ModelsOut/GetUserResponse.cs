namespace VirtualPark.WebApi.Controllers.Users.ModelsOut;

public class GetUserResponse(string id, string name, string lastName)
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string LastName { get; } = lastName;
}
