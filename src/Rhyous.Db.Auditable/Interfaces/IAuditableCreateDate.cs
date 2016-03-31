using System;

namespace Rhyous.Db.Auditable
{
    public interface IAuditableCreateDate
    {
        /// <summary>
        /// The date the row was created.
        /// You can use the Column attribute to change the actual 
        /// database column name if needed. 
        /// Example: [Column("Date")]
        /// </summary>
        DateTime CreateDate { get; set; }
    }
}