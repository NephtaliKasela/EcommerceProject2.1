namespace EcommerceProject.Services.UserServices
{
    public interface IUserServices
    {
        Task<int> GetUserId(string userName);
    }
}
