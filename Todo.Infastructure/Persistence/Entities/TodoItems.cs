using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Infastructure.Persistence.Entities
{
    public class TodoItems : BaseAuditableEntity
    {
        public Guid TodoListId { get; set; }
        public TodoLists? TodoList { get; set; }

        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        
        public int Priority { get; set; }
        public int Status { get; set; }

        public DateTime? DueDate { get; set; }
        public DateTime? ReminderDate { get; set; }
        public DateTime? CompletedAt { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Tags>? Tags { get; set; }
        public ICollection<Comments>? Comments { get; set; }
    }
}
