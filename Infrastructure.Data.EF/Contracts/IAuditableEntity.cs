using System;

namespace Raitan.Infrastructure.Data.EF.Contracts
{
    public interface IAuditableEntity : IEntity
    {
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
    }
}