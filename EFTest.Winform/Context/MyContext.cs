using Raitan.Infrastructure.Data.EF.Context;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    public class MyContext : Context, IMyContext
    {
        public MyContext() : base("Name=MyContext")
        {

        }

        public IDbSet<Person> People { get; set; }
    }
}
