namespace FiorelloBack.Services.Interfaces
{
    public interface ISocialService
    {
        Task<Dictionary<string, string>> GetAllAsync();
    }
}
