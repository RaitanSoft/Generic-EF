using Raitan.Infrastructure.Data.EF.SuperTypes;

namespace WindowsFormsApp1
{
    public class PersonRepository : EntityRepository<Person>, IPersonRepository
    {
        public PersonRepository(IMyContext context) : base(context)
        {

        }
    }
}
