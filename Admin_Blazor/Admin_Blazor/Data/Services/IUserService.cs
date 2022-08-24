using Admin_Blazor.Data.Models;

namespace Admin_Blazor.Data.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<User> GetUser(Guid id);
        Task<bool> DeleteUser(Guid id);
        Task<bool> UpdateUserRole(Guid id, User user);


    }
}
