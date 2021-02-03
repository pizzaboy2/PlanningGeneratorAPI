

namespace PlanningGeneratorAPI.Repositories
{
    public interface IPlanningRepo 
    {
        List<User> GetAllUsers();
        User GetUserById(int id);    
    }
}