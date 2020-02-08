using Raitan.Infrastructure.Data.EF.SuperTypes;

namespace WindowsFormsApp1
{
    public class Person : AuditableEntity
    {
        public string Name { get; set; }
    }
}
