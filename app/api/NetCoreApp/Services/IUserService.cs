using NetCoreApp.Entities;
using NetCoreApp.Models.User;

namespace NetCoreApp.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Create(CreateRequest model);
        void Update(int id, UpdateRequest model);
        void Delete(int id);
    }
}
