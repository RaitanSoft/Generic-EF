using Raitan.Infrastructure.Data.EF.Contracts;
using System;

namespace Raitan.Infrastructure.Data.EF.SuperTypes
{
    public abstract class AuditableEntity : Entity, IAuditableEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}