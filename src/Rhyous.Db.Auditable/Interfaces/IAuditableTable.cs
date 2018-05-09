namespace Rhyous.Db.Auditable
{
    public interface IAuditableTable<TId> : IAuditableDates, IAuditableUsers<TId>
        where TId : struct
    {
    }
}
