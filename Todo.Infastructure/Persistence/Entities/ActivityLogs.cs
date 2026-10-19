using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Infastructure.Persistence.Entities
{
    public class ActivityLogs : BaseAuditableEntity
    {
        public string TodoItemId { get; set; } = string.Empty;
        public string ActivityType { get; set; } = string.Empty;
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string PerformedBy { get; set; } = string.Empty;
        public DateTime PerformedAt { get; set; } = DateTime.UtcNow;
    }
}
