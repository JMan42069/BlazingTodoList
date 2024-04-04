using BlazingTodoList.Data;
using BlazingTodoList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Drawing.Text;
using BlazingTodoList.Components.Account;

namespace BlazingTodoList.Controllers;

    [Route("items")]
    [ApiController]
    public class TodoItemController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TodoItemController(ApplicationDbContext context)
        {
            _context = context;
        }


        //TODO: get all todoitems for specific user
        [HttpGet("{userId}")]
        public async Task<ActionResult<List<TodoItem>>> GetTodoItemsByUserID(string userId)
        {
            
            var items = await _context.TodoItems
                .Where(x => x.UserId == userId)
                .ToListAsync();

            return items;
        }

    //TODO: get contents of a single todoItem for a user
    [HttpGet("{userId}/{itemId}")]
    public async Task<ActionResult<List<TodoItem>>> GetTodoItemsByItemID(string userId, int itemId)
    {
        var items = await _context.TodoItems
            .Where(x => x.UserId == userId && x.ItemId == itemId)
            .ToListAsync();

        return items;
    }

    //TODO: delete a todoitem for specific user

    //TODO: edit (quick edit: mark todo item as completed)

    //TODO: Update todoitem


}

