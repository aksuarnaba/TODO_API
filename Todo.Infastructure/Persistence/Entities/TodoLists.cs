using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Infastructure.Persistence.Entities
{
    public class TodoLists : BaseAuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
