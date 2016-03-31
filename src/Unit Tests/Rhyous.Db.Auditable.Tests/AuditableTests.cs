using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhyous.Db.Auditable.Tests.Fakes;

namespace Rhyous.Db.Auditable.Tests
{
    [TestClass]
    public class AuditableTests
    {
        public readonly TimeSpan AcceptableTimeSpan = new TimeSpan(0, 0, 5);

        [TestMethod]
        public void TestMethodAdd()
        {
            // Arrange
            using (var dbContext = new MyDbContext())
            {
                //var dbContext = mock.Object;
                var person = new Person { Id = 1, Name = "Rhyous" };
                dbContext.People.Add(person);

                // Act
                dbContext.HandleAuditables(dbContext.User100);

                // Assert
                Assert.IsTrue(DateTime.Now - person.CreateDate < AcceptableTimeSpan);
                Assert.AreEqual(null, person.LastUpdated);
                Assert.AreEqual(dbContext.User100, person.CreatedBy);
                Assert.AreEqual(null, person.LastUpdatedBy);
            }
        }

        [TestMethod]
        public void TestMethodUpdate()
        {
            // Arrange
            using (var dbContext = new MyDbContext())
            {
                //var dbContext = mock.Object;
                var person = new Person { Id = 1, Name = "Rhyous" };
                dbContext.People.Attach(person);
                dbContext.Entry(person).State = EntityState.Modified;

                // Act
                dbContext.HandleAuditables(dbContext.User200);

                // Assert
                Assert.IsTrue(DateTime.Now - person.LastUpdated < AcceptableTimeSpan);
                Assert.AreEqual(default(DateTime), person.CreateDate);
                Assert.AreEqual(dbContext.User200, person.LastUpdatedBy);
                Assert.AreEqual(0, person.CreatedBy);
            }
        }
    }
}
