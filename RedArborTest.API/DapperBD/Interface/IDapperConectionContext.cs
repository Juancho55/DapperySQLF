using System.Data;

namespace DapperBD.Interface
{
    public interface IDapperConectionContext
    {
        public IDbConnection GetSqlCnn();
    }
}
