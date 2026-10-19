using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Infastructure.Persistence.Entities
{
    public class TodoItemTags : BaseAuditableEntity
    {
        public TodoItems? TodoItemId { get; set; }
        public Tags? Tag { get; set; }
    }
}
