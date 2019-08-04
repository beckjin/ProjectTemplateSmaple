using UserService.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ServiceDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IUserService _demoService;
        public DemoController(IUserService demoService)
        {
            _demoService = demoService;
        }

        [HttpGet]
        public Task<int> DemoMethod(int id)
        {
            return _demoService.DemoMethodAsync(id);
        }
    }
}
