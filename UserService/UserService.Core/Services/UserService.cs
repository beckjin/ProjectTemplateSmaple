using UserService.Core.Repositories;
using System.Threading.Tasks;

namespace UserService.Core.Services
{
    public interface IUserService
    {
        Task<int> DemoMethodAsync(int id);
    }

    public class UserService : IUserService
    {
        private readonly IDemoRepository _demoRepository;
        public UserService(IDemoRepository demoRepository)
        {
            _demoRepository = demoRepository;
        }

        public Task<int> DemoMethodAsync(int id)
        {
            return _demoRepository.DemoMethodAsync(id);
        }
    }
}
