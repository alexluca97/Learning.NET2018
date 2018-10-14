using System;
using Xunit;

namespace LibraryClass.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GivenNewArchitect_ShouldBeNamedProperly()
        {
            var person = new Architect(1, "Luca", "Alexandru",DateTime.Now, DateTime.Today.AddDays(1), 250.00);
            Assert.Equal("Luca Alexandru",person.GetFullName());
        }

        [Fact]
        public void GivenNewManager_ShouldBeNamedProperly()
        {
            var person = new Manager(1, "Luca", "Alexandru", DateTime.Now, DateTime.Today.AddDays(1), 250.00);
            Assert.Equal("Luca Alexandru", person.GetFullName());
        }

        [Fact]
        public void GivenGoodArchitectStartDate_ShouldBeActive()
        {
            var arhitect1 = new Architect(1, "Luca", "Alexandru", DateTime.Now, DateTime.Today.AddDays(1), 250);
            Assert.False(arhitect1.IsActive());
        }

        [Fact]
        public void GivenBadArchitectStartDate_ShouldNotBeActive()
        {
            var arhitect2 = new Architect(1, "Anton", "Vlad", DateTime.Now, DateTime.Now, 220);
            Assert.False(arhitect2.IsActive());
        }

        [Fact]
        public void GivenGoodManagerStartDate_ShouldBeActive()
        {
            var manager1 = new Manager(1, "Luca", "Alexandru", DateTime.Now, DateTime.Today.AddDays(1), 250);
            Assert.True(manager1.IsActive());
        }

        [Fact]
        public void GivenBadManagerStartDate_ShouldNotBeActive()
        {
            var manager2 = new Manager(1, "Anton", "Vlad", DateTime.Now, DateTime.Today.AddDays(-1), 220);
            Assert.False(manager2.IsActive());
        }

        [Fact]
        public void GivenNewArchitect_SalutationShouldReturnHelloArhitect()
        {
            var arhitect = new Architect(1, "Luca", "Alexandru", DateTime.Now, DateTime.Today.AddDays(1), 250);
            Assert.Equal("Hello arhitect", arhitect.Salutation());
        }

        [Fact]
        public void GivenNewEmployee_SalutationShouldReturnHello()
        {
            var employee = new Employee(1, "Luca", "Alexandru", DateTime.Now, DateTime.Today.AddDays(1), 250);
            Assert.Equal("Hello", employee.Salutation());
        }

        [Fact]
        public void GivenNewEmployee_ShouldHaveId1()
        {
            var employee = new Employee(1, "Luca", "Alexandru", DateTime.Now, DateTime.Today.AddDays(1), 250);
            Assert.Equal(1, employee.Id);
        }

        [Fact]
        public void GivenNewManager_SalutationShouldReturnHelloManager()
        {
            var manager = new Manager(1, "Luca", "Alexandru", DateTime.Now, DateTime.Today.AddDays(1), 250);
            Assert.Equal("Hello manager", manager.Salutation());
        }
    }
}
