using Dapper;
using bUtility.Dapper;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Data.ExternalStorage
{
    public class Db : IDb
    {
        private readonly IDbConnection dbc;
        public Db(string ConnectionString)
        {
            dbc = new SqlConnection(ConnectionString);
        }
        public int InsertMindName(MindName mindName)
        {
            int rowsAffected = dbc.Insert<MindName>(mindName, null, 18, null);
            return rowsAffected;
        }
        public int DeleteMindName(object mindName)
        {
            int rowsAffected = dbc.Delete<MindName>(mindName, null, 18, null);
            return rowsAffected;
        }
        public List<MindName> SelectMindName()
        {
            List<MindName> result = dbc.Select<MindName>().ToList();
            return result;
        }
        public List<MindName> SelectMindName(object mindName)
        {
            List<MindName> result = dbc.Select<MindName>(mindName, null, true, 18, null).ToList();
            return result;
        }
        public int UpdateMindName(object mindName)
        {
            int rowsAffected = dbc.Delete<MindName>(mindName, null, 18, null);
            return rowsAffected;
        }
    }
}
