using Microsoft.AspNetCore.Mvc;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/rota")]
        public List<TodoModel> Get([FromServices]AppDbContext context)
        {

            return context.Todos.ToList();
        }

        [HttpPost("/")]
        public TodoModel Post(
            [FromBody] TodoModel todo,
            [FromServices] AppDbContext context)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
            return todo;
        }
    }
}
