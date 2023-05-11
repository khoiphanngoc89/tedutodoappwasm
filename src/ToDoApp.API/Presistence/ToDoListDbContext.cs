using Microsoft.EntityFrameworkCore;
using Task = ToDoApp.API.Entities.Task;

namespace ToDoApp.API.Presistence;

public class ToDoListDbContext : DbContext
{
    public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options) : base(options)
    {
    }

    public DbSet<Task> Tasks { get; set; }
}
