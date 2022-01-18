using MvcProject.Models;

namespace MvcProject.Repository
{
    public interface IMockUserRepository
    {
        IEnumerable<Models.MockUser> GetAll();
    }
}
