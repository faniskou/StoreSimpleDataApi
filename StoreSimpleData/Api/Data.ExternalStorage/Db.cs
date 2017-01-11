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
        public int InsertMindTarget(MindTarget MindTarget)
        {
            int rowsAffected = dbc.Insert<MindTarget>(MindTarget, null, 18, null);
            return rowsAffected;
        }
        public int DeleteMindTarget(object MindTarget)
        {
            int rowsAffected = dbc.Delete<MindTarget>(MindTarget, null, 18, null);
            return rowsAffected;
        }
        public List<MindTarget> SelectMindTarget()
        {
            List<MindTarget> result = dbc.Select<MindTarget>().ToList();
            return result;
        }
        public List<MindTarget> SelectMindTarget(object MindTarget)
        {
            List<MindTarget> result = dbc.Select<MindTarget>(MindTarget, null, true, 18, null).ToList();
            return result;
        }
        public int UpdateMindTarget(object MindTarget)
        {
            string updatePart = typeof(MindTarget).GetUpdateClause((p) => (new string[] { "Id", "Target"}.Contains(p.Name)));
            int rowsAffected = dbc.Execute(Statements<MindTarget>.GetUpdate(updatePart, @"Id=@Id"), MindTarget , null);
            return rowsAffected;
        }
    }
}
