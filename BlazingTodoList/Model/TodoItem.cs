using BlazingTodoList.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace BlazingTodoList.Model
{
    public class TodoItem
    {
        [Key]
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string ItemDesc { get; set; }

        public bool Completed { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
