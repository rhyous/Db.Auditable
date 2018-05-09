using System;

namespace Rhyous.Db.Auditable
{
    public abstract class AuditableEntity<TId> : IAuditableTable<TId>
        where TId : struct
    {
        /// <inheritdoc />
        public virtual DateTime CreateDate { get; set; }
        /// <inheritdoc />
        public virtual DateTime? LastUpdated { get; set; }
        /// <inheritdoc />
        public virtual TId CreatedBy { get; set; }
        /// <inheritdoc />
        public virtual TId? LastUpdatedBy { get; set; }
    }
}
