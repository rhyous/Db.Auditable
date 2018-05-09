using System;

namespace Rhyous.Db.Auditable
{
    public interface IAuditableLastUpdatedBy<TId>
        where TId : struct
    {
        /// <summary>
        /// The user who updated the row most recently. This value
        /// is null on row creation and populated on first change.
        /// You can use the Column attribute to change the actual 
        /// database column name if needed. 
        /// Example: [Column("ModifiedBy")]
        /// </summary>
        TId? LastUpdatedBy { get; set; }
    }
}