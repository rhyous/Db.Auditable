namespace Rhyous.Db.Auditable.Tests.Fakes
{
    public class Person : AuditableEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
