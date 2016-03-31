using System.Data.Entity;

namespace Rhyous.Db.Auditable
{
    public sealed class AuditableDbSet<T> : DbSet<T>
        where T : class, IAuditableTable, new()
    {
        public AuditableDbSet()
        {
        }

        public AuditableDbSet(IDbSet<T> set)
        {
            foreach (var entity in set)
            {
                Add(entity);
            }
        }
    }
}
