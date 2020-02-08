using Raitan.Infrastructure.Data.EF.SuperTypes;

namespace WindowsFormsApp1
{
    public interface IPersonRepository : IEntityRepository<Person>
    {
    }
}