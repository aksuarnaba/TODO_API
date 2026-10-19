using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Infastructure.Persistence.Entities
{
    public class Tags : BaseAuditableEntity
    {
        public string Name { get; set; } = string.Empty;
    }
}
