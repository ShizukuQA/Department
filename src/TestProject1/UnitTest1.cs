using WindowsFormsApp2.Database;
using WindowsFormsApp2.Database.Models;

namespace TestProject1 {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void TestGettingUserBeforeAdding() {
            DatabaseContext databaseContext = new DatabaseContext("DataSource=TestingDatabase.db");

            User user = databaseContext.Users.FirstOrDefault(x => x.Firstname == "Tester");
            Assert.IsNull(user);
        }

        [Test]
        public void TestGettingUserAfterAdding() {
            DatabaseContext databaseContext = new DatabaseContext("DataSource=TestingDatabase.db");
            User user = new User() {
                Firstname = "Tester",
                SecondName = "Tester",
                Email = "Tester@tester.test",
                IsAdmin = true,
                Password = "Tester"
            };
            databaseContext.Users.Add(user);
            databaseContext.SaveChanges();

            User _user = databaseContext.Users.FirstOrDefault(x => x.Firstname == "Tester");
            Assert.IsNotNull(_user);
        }

        [Test]
        public void TestCheckUserData() {
            DatabaseContext databaseContext = new DatabaseContext("DataSource=TestingDatabase.db");
            User user = new User() {
                Firstname = "Tester2",
                SecondName = "Tester2",
                Email = "Tester2@tester.test",
                IsAdmin = true,
                Password = "Tester2"
            };
            databaseContext.Users.Add(user);
            databaseContext.SaveChanges();

            User _user = databaseContext.Users.FirstOrDefault(x => x.Firstname == "Tester2");
            Assert.Equals(user, _user);
        }
    }
}