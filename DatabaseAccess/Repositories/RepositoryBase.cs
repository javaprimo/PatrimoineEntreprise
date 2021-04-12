using System.Data.SqlClient;

namespace DatabaseAccess.Repositories
{
    public class RepositoryBase
    {
        public static SqlParameter GetParam(string ParamName, object paramValue)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = ParamName;
            param.Value = paramValue;

            return param;
        }
    }
}
