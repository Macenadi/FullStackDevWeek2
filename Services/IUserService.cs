namespace FullStackDevWeek2.Services
{
    public interface IUserService
    {

        Task<List<Models.User>> GetUsersAsync();


        Task<Models.User> GetUserByIdAsync(int id);


    }
}
