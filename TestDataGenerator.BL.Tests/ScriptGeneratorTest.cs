using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestDataGenerator.Data;

namespace TestDataGenerator.BL.Tests
{
    [TestFixture]
    public class ScriptGeneratorTest
    {
        private IScriptGenrator _generator;

        [SetUp]
        public void Init()
        {
            IRepository repository = new RepositoryMock();
            _generator = new ScriptGenerator(repository);
        }

        [Test]
        public void GenerateUser_NameRequired()
        {
            UserEntity entity = _generator.GenerateUser();
            string name = entity.Name;

            Assert.That(name, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_SurnameRequired()
        {
            UserEntity entity = _generator.GenerateUser();
            string surname = entity.Surname;

            Assert.That(surname, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_LoginRequired()
        {
            UserEntity entity = _generator.GenerateUser();
            string login = entity.Login;

            Assert.That(login, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_PasswordRequired()
        {
            UserEntity entity = _generator.GenerateUser();
            string password = entity.Password;

            Assert.That(password, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_EmailRequired()
        {
            UserEntity entity = _generator.GenerateUser();
            string email = entity.Email;

            Assert.That(email, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_RegistrationDatePeriod()
        {
            UserEntity entity = _generator.GenerateUser();
            DateTime registrationDate = entity.RegistrationDate;

            Assert.That(registrationDate, Is.InRange(new DateTime(2010, 1, 1), new DateTime(2016, 2, 29)));
        }

        [Test]
        public void GenerateUser_GetValueLine()
        {
            UserEntity user = new UserEntity()
            {
                Name = "Петя",
                Surname = "1",
                Patronymic = "2",
                Email = "3",
                Login = "4",
                Password = "5",
                RegistrationDate = new DateTime(2016, 1, 1)
            };

            const string EXPECTED_RESULT = @"VALUES ('Петя', '1', '2', '3', '4', '5', '20160101')";
            string result = _generator.GetValueLine(user);

            Assert.That(result, Is.EqualTo(EXPECTED_RESULT));
        }
    }
}
