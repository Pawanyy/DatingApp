using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //localhost/api/users
    public class UsersController: ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(Data.DataContext context)
        {
            _context = context;
        }
    }
}