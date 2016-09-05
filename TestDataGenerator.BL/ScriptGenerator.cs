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
        private readonly IRepository _repository;

        public ScriptGenerator(IRepository repository)
        {
            _repository = repository;
        }

        public UserEntity GenerateUser()
        {
            UserEntity entity = new UserEntity();

            entity.Login = _repository.GetRandomUniqLogin();
            entity.Name = _repository.GetRandomName();
            entity.Surname = _repository.GetRandomSurname();
            entity.Patronymic = _repository.GetRandomPatronymic();

            string randomEmailDomain = _repository.GetRandomEmailDomain();
            entity.Email = string.Format("{0}@{1}", entity.Login, randomEmailDomain);

            return entity;
        }

        public string CreateScript(int entityCount)
        {
            throw new NotImplementedException();
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
