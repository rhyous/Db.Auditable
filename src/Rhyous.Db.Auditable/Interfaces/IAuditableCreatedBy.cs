namespace Rhyous.Db.Auditable
{
    public interface IAuditableCreatedBy
    {
        /// <summary>
        /// The user who created the row.
        /// You can use the Column attribute to change the actual 
        /// database column name if needed. 
        /// Example: [Column("User")]
        /// </summary>
        int CreatedBy { get; set; }
    }
}