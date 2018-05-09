namespace Rhyous.Db.Auditable
{
    public interface IAuditableUsers<TId> : IAuditableCreatedBy<TId>, IAuditableLastUpdatedBy<TId>
        where TId : struct
    {
    }
}
