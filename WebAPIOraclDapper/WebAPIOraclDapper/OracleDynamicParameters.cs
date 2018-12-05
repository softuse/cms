using System.Data;
using Dapper;

namespace WebAPIOraclDapper
{
    internal class OracleDynamicParameters:SqlMapper.IDynamicParameters
    {
        public OracleDynamicParameters()
        {
        }

        public void AddParameters(IDbCommand command, SqlMapper.Identity identity)
        {
            throw new System.NotImplementedException();
        }
    }
}