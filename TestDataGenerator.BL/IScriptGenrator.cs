using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataGenerator.Data;

namespace TestDataGenerator.BL
{
    public interface IScriptGenrator
    {
        UserEntity GenerateUser();
        string GetValueLine(UserEntity entity);
        string GetInsertLine();        
        string CreateScript(int entityCount);
    }
}
