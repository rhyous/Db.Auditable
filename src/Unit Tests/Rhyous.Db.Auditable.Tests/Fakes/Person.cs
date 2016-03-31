namespace Rhyous.Db.Auditable.Tests.Fakes
{
    public class Person : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
