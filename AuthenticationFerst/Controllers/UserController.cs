using Microsoft.AspNetCore.Mvc;

namespace AuthenticationFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private ILogger _logger;

        public UserController(ILogger loger)
        {
            _logger = loger;

            _logger.WriteError("Error message!");
            _logger.WriteEvent("Event message!");
        }

        public User GetUser()
        {
            return new User()
            {
                LastName = "Ivanov",
                Name = "Ivan",
                Email = "asdfa@adsfa.ru",
                Id = Guid.NewGuid(),
                Login = "ivanov",
                Password = "qwer1234"
            };

        }
    }
}
