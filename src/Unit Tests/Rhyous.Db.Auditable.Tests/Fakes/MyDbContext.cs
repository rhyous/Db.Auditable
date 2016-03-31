using System.Data.Entity;

namespace Rhyous.Db.Auditable.Tests.Fakes
{
    public class MyDbContext : AuditableDbContext
    {
        internal int User100 = 100;
        internal const int User200 = 200;
        
        public virtual DbSet<Person> People { get; set; }

        public override int GetCurrentUserId()
        {
            return User100;
        }
    }
}
