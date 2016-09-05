using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataGenerator.Data;

namespace TestDataGenerator.BL.Tests
{
    public class RepositoryMock : IRepository
    {
        public string GetRandomEmailDomain()
        {
            return "da.ru";
        }

        public string GetRandomName()
        {
            return "Petya";
        }

        public string GetRandomPatronymic()
        {
            return "Petrovich";
        }

        public string GetRandomSurname()
        {
            return "Petrov";
        }

        public string GetRandomUniqLogin()
        {
            return "Petya1337";
        }

        public void Init()
        {
            throw new NotImplementedException();
        }
    }
}
