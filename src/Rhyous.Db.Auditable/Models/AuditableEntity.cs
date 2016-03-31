using System;

namespace Rhyous.Db.Auditable
{
    public abstract class AuditableEntity : IAuditableTable
    {
        /// <inheritdoc />
        public virtual DateTime CreateDate { get; set; }
        /// <inheritdoc />
        public virtual DateTime? LastUpdated { get; set; }
        /// <inheritdoc />
        public virtual int CreatedBy { get; set; }
        /// <inheritdoc />
        public virtual int? LastUpdatedBy { get; set; }
    }
}
