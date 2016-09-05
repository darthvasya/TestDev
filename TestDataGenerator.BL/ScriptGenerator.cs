using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataGenerator.Data;

namespace TestDataGenerator.BL
{
    public class ScriptGenerator : IScriptGenrator
    {
        public string CreateScript(int entityCount)
        {
            throw new NotImplementedException();
        }

        public UserEntity GenerateUser()
        {
            Repository repository = new Repository();
            UserEntity entity = new UserEntity();

            entity.Login = repository.GetRandomUniqLogin();
            entity.Name = repository.GetRandomName();
            entity.Surname = repository.GetRandomSurname();
            entity.Patronymic = repository.GetRandomPatronymic();

            string randomEmailDomain = repository.GetRandomEmailDomain();
            entity.Email = string.Format("{0}@{1}", entity.Login, randomEmailDomain);

            return entity;
        }

        public string GetInsertLine()
        {
            throw new NotImplementedException();
        }

        public string GetValueLine(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
