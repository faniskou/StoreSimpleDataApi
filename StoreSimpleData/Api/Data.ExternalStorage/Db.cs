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
        private readonly IDbConnection dbc;
        public Db(string ConnectionString)
        {
            dbc = new SqlConnection(ConnectionString);
        }
        //mindTarget
        public int InsertMindTarget(MindTarget MindTarget)
        {
            int rowsAffected = dbc.Insert<MindTarget>(MindTarget);
            return rowsAffected;
        }
        public int DeleteMindTarget(object MindTarget)
        {
            int rowsAffected = dbc.Delete<MindTarget>(MindTarget);
            return rowsAffected;
        }
        public List<MindTarget> SelectMindTarget()
        {
            return dbc.Select<MindTarget>().ToList();
        }
        public List<MindTarget> SelectMindTarget(object MindTarget)
        {
            if (MindTarget == null || IsAll1stChildsNull(MindTarget))
            {
                return dbc.Select<MindTarget>().ToList();
            }
            else
            {
                return dbc.Select<MindTarget>(MindTarget).ToList();
            }
        }
        public int UpdateMindTarget(object MindTarget)
        {
            string updatePart = typeof(MindTarget).GetUpdateClause((p) => (new string[] { "Id", "Target" }.Contains(p.Name)));
            int rowsAffected = dbc.Execute(Statements<MindTarget>.GetUpdate(updatePart, @"Id=@Id"), MindTarget, null);
            return rowsAffected;
        }
        //mindReceivedData
        public int InsertMindReceivedData(MindReceivedData MindReceivedData)
        {
            int rowsAffected = dbc.Insert<MindReceivedData>(MindReceivedData);
            return rowsAffected;
        }
        public int DeleteMindReceivedData(object MindReceivedData)
        {
            int rowsAffected = dbc.Delete<MindReceivedData>(MindReceivedData);
            return rowsAffected;
        }
        public List<MindReceivedData> SelectMindReceivedData()
        {
            return dbc.Select<MindReceivedData>().ToList();
        }
        public List<MindReceivedData> SelectMindReceivedData(object MindReceivedData)
        {
            if (MindReceivedData == null || IsAll1stChildsNull(MindReceivedData))
            {
                return dbc.Select<MindReceivedData>().ToList();
            }
            else
            {
                return dbc.Select<MindReceivedData>(MindReceivedData).ToList();
            }
        }
        public int UpdateMindReceivedData(object MindReceivedData)
        {
            string updatePart = typeof(MindReceivedData).GetUpdateClause((p) => (new string[] { "Id", "Target", "Details", "Title", "Approved" }.Contains(p.Name)));
            int rowsAffected = dbc.Execute(Statements<MindReceivedData>.GetUpdate(updatePart, @"Id=@Id"), MindReceivedData, null);
            return rowsAffected;
        }
        ////MindDerivedData
        public int InsertMindDerivedData(MindDerivedData MindDerivedData)
        {

            int rowsAffected = dbc.Insert<MindDerivedData>(MindDerivedData);
            return rowsAffected;
        }
        public int DeleteMindDerivedData(object MindDerivedData)
        {
            int rowsAffected = dbc.Delete<MindDerivedData>(MindDerivedData);
            return rowsAffected;
        }
        public List<MindDerivedData> SelectMindDerivedData()
        {
            return dbc.Select<MindDerivedData>().ToList();
        }
        public List<MindDerivedData> SelectMindDerivedData(object MindDerivedData)
        {
            if (MindDerivedData == null || IsAll1stChildsNull(MindDerivedData))
            {
                return dbc.Select<MindDerivedData>().ToList();
            }
            else
            {
                return dbc.Select<MindDerivedData>(MindDerivedData).ToList();
            }
        }
        public int UpdateMindDerivedData(object MindDerivedData)
        {
            string updatePart = typeof(MindDerivedData).GetUpdateClause((p) => (new string[] { "Id", "Details", "Title", "Score", "MaxTarget" }.Contains(p.Name)));
            int rowsAffected = dbc.Execute(Statements<MindDerivedData>.GetUpdate(updatePart, @"Id=@Id"), MindDerivedData, null);
            return rowsAffected;
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
                    if (pi != null) {
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
