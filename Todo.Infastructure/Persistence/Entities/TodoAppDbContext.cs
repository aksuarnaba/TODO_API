using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Todo.Infastructure.Persistence.Entities
{
    public class TodoAppDbContext : DbContext
    {

        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<TodoLists> TodoLists { get; set; }
        public DbSet<TodoItems> TodoItems { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<TodoItemTags> TodoItemTags { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<ActivityLogs> ActivityLogs { get; set; }
    }
}
