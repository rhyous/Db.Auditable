using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Rhyous.Db.Auditable
{
    public class AuditablesHandler<TId>
        where TId : struct
    {
        public static void HandleAuditableCreatedBy(DbChangeTracker tracker, TId userId)
        {
            foreach (var auditableEntity in tracker.Entries<IAuditableCreatedBy<TId>>().Where(auditableEntity => auditableEntity.State == EntityState.Added))
            {
                auditableEntity.Entity.CreatedBy = userId;
            }
        }

        public static void HandleAuditableLastUpdatedBy(DbChangeTracker tracker, TId userId)
        {
            foreach (var auditableEntity in tracker.Entries<IAuditableLastUpdatedBy<TId>>().Where(auditableEntity => auditableEntity.State == EntityState.Modified))
            {
                auditableEntity.Entity.LastUpdatedBy = userId;
            }
        }


        public static void HandleAuditableCreateDate(DbChangeTracker tracker)
        {
            foreach (var auditableEntity in tracker.Entries<IAuditableCreateDate>().Where(auditableEntity => auditableEntity.State == EntityState.Added))
            {
                auditableEntity.Entity.CreateDate = DateTime.Now;
            }
        }

        public static void HandleAuditableLastUpdated(DbChangeTracker tracker)
        {
            foreach (var auditableEntity in tracker.Entries<IAuditableLastUpdatedDate>().Where(auditableEntity => auditableEntity.State == EntityState.Modified))
            {
                auditableEntity.Entity.LastUpdated = DateTime.Now;
            }
        }
    }
}
