using System;

namespace Rhyous.Db.Auditable
{
    public abstract class AuditableEntity : IAuditableTable
    {
        /// <inheritdoc />
        public DateTime CreateDate { get; set; }
        /// <inheritdoc />
        public DateTime? LastUpdated { get; set; }
        /// <inheritdoc />
        public int CreatedBy { get; set; }
        /// <inheritdoc />
        public int? LastUpdatedBy { get; set; }
    }
}
