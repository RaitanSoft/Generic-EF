using Raitan.Infrastructure.Data.EF.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Raitan.Infrastructure.Data.EF.SuperTypes
{
    public abstract class Entity : BaseEntity, IEntity
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual long Id { get; set; }

        public virtual bool IsActive { get; set; }
    }
}