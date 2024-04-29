using Microsoft.AspNetCore.Mvc;

namespace ToDo.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/rota")]
        public string Get()
        {
            return "Hello world";
        }
    }
}
