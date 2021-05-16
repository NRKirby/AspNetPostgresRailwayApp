using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetPostgresRailwayApp.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetPostgresRailwayApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly Context _context;

        public TodoController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Todo>> Get()
        {
           var todos = await _context.Todos.ToListAsync();
           return todos;
        }
    }
}
