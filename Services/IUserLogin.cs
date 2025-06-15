namespace RealWorldBackend.Services
{
    public interface IUserLogin
    {
        object GenerateJwtToken(string username);
    }
}
