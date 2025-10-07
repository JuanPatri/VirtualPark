namespace VirtualPark.WebApi.Controllers.Sessions.ModelsOut;

public class CreateSessionResponse(string token)
{
    public string Token { get; } = token;
}
