using Dapper;
using bUtility.Dapper;

using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace Data.ExternalStorage
{
    public class Db : IDb
    {
        // private readonly IDbConnection dbc;
        readonly Func<System.Data.IDbConnection> DbConnection;
        public Db(Func<System.Data.IDbConnection> dbConnection)
        {
            DbConnection = dbConnection;
        }
        //Target
        public int InsertMindTarget(MindTarget MindTarget)
        {
            int result;
            using (var dbc = DbConnection())
            {
                string sqlQuery = "INSERT INTO [dbo].[MindTarget]([Target]) VALUES (@Target)";
                result = dbc.Execute(sqlQuery, new { MindTarget.Target });
            }
            return result;
        }
        public int DeleteMindTarget(object MindTarget)
        {
            int result;
            using (var dbc = DbConnection())
            {
                result = dbc.Delete<MindTarget>(MindTarget, null, 0, null, null);
            }
            return result;
        }
        public List<MindTarget> SelectMindTarget()
        {
            List<MindTarget> result;
            using (var dbc = DbConnection())
            {
                result = dbc.Select<MindTarget>().ToList();
            }
            return result;
        }
        public List<MindTarget> SelectMindTarget(object MindTarget)
        {
            List<MindTarget> result;
            using (var dbc = DbConnection())
            {
                if (MindTarget == null || IsAll1stChildsNull(MindTarget))
                {
                    result = dbc.Select<MindTarget>().ToList();
                }
                else
                {
                    result = dbc.Select<MindTarget>(MindTarget).ToList();
                }
            }
            return result;
        }
        public int UpdateMindTarget(object MindTarget)
        {
            int result;
            using (var dbc = DbConnection())
            {
                string updatePart = typeof(MindTarget).GetUpdateClause((p) => (new string[] { "Target" }.Contains(p.Name)));
                result = dbc.Execute(Statements<MindTarget>.GetUpdate(updatePart, @"Id=@Id"), MindTarget, null);
            }
            return result;
        }
        //mindTrainedData
        public int InsertMindTrainedData(MindTrainedData MindTrainedData)
        {
            int result;
            using (var dbc = DbConnection())
            {
                string sqlQuery = "INSERT INTO [dbo].[MindTrainedData]([Target],[Title],[Approved],[Details]) VALUES (@Target,@Title,@Approved,@Details)";
                result = dbc.Execute(sqlQuery,
                     new { MindTrainedData.Target, MindTrainedData.Title, MindTrainedData.Approved, MindTrainedData.Details });
            }
            return result;
        }
        public int DeleteMindTrainedData(object MindTrainedData)
        {
            int result;
            using (var dbc = DbConnection())
            {
                result = dbc.Delete<MindTrainedData>(MindTrainedData);
            }
            return result;
        }
        public List<MindTrainedData> SelectMindTrainedData()
        {
            List<MindTrainedData> result;
            using (var dbc = DbConnection())
            {
                result = dbc.Select<MindTrainedData>().ToList();
            }
            return result;
        }
        public List<MindTrainedData> SelectMindTrainedData(object MindTrainedData)
        {
            List<MindTrainedData> result;
            using (var dbc = DbConnection())
            {
                if (MindTrainedData == null || IsAll1stChildsNull(MindTrainedData))
                {
                    result = dbc.Select<MindTrainedData>().ToList();
                }
                else
                {
                    result = dbc.Select<MindTrainedData>(MindTrainedData).ToList();
                }
            }
            return result;
        }
        public int UpdateMindTrainedData(object MindTrainedData)
        {
            int result;
            using (var dbc = DbConnection())
            {
                string updatePart = typeof(MindTrainedData).GetUpdateClause((p) => (new string[] { "Target", "Details", "Title", "Approved" }.Contains(p.Name)));
                result = dbc.Execute(Statements<MindTrainedData>.GetUpdate(updatePart, @"Id=@Id"), MindTrainedData, null);
            }
            return result;
        }
        ////MindReceivedData
        public int InsertMindReceivedData(MindReceivedData MindReceivedData)
        {
            int result;
            using (var dbc = DbConnection())
            {
                string sqlQuery = "INSERT INTO [dbo].[MindReceivedData]([MaxTarget],[Title],[Score],[Details]) VALUES (@MaxTarget,@Title,@Score,@Details)";
                result = dbc.Execute(sqlQuery,
                     new { MindReceivedData.MaxTarget, MindReceivedData.Title, MindReceivedData.Score, MindReceivedData.Details });
            }
            return result;
        }
        public int DeleteMindReceivedData(object MindReceivedData)
        {
            int result;
            using (var dbc = DbConnection())
            {
                result = dbc.Delete<MindReceivedData>(MindReceivedData);
            }
            return result;
        }
        public List<MindReceivedData> SelectMindReceivedData()
        {
            List<MindReceivedData> result;
            using (var dbc = DbConnection())
            {
                result = dbc.Select<MindReceivedData>().ToList();
            }
            return result;
        }
        public List<MindReceivedData> SelectMindReceivedData(object MindReceivedData)
        {
            List<MindReceivedData> result;
            using (var dbc = DbConnection())
            {
                if (MindReceivedData == null || IsAll1stChildsNull(MindReceivedData))
                {
                    result = dbc.Select<MindReceivedData>().ToList();
                }
                else
                {
                    result = dbc.Select<MindReceivedData>(MindReceivedData).ToList();
                }
            }
            return result;
        }
        public int UpdateMindReceivedData(object MindReceivedData)
        {
            int result;
            using (var dbc = DbConnection())
            {
                string updatePart = typeof(MindReceivedData).GetUpdateClause((p) => (new string[] { "Details", "Title", "Score", "MaxTarget" }.Contains(p.Name)));
                result = dbc.Execute(Statements<MindReceivedData>.GetUpdate(updatePart, @"Id=@Id"), MindReceivedData, null);
            }
            return result;
        }


        bool IsAll1stChildsNull(object myObject)
        {
            foreach (System.Reflection.PropertyInfo pi in myObject.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(myObject);
                    if (value != null)
                    {
                        return false;
                    }
                }
                else
                {
                    if (pi != null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        bool IsAnyNullOrEmpty(object myObject)
        {
            foreach (System.Reflection.PropertyInfo pi in myObject.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(myObject);
                    if (string.IsNullOrEmpty(value))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
