using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Infastructure.Persistence.Entities
{
    public class Comments : BaseAuditableEntity
    {
        public required string TodoItemId { get; set; }
        public required string CommentText { get; set; }

    }
}
