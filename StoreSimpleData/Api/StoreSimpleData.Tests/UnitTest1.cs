using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.ExternalStorage;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StoreSimpleData.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public static SqlConnection GetDbcon() { return new SqlConnection(ConfigurationManager.AppSettings["Dbcon"]); }
        Func<SqlConnection> GetDb = GetDbcon;

        [TestMethod]
        public void ConnectToDatabase()
        {
            IDb db = new Db(GetDb);
            MindTarget input = new MindTarget() {  Target = null };
            var a = db.DeleteMindTarget(input);
            Console.Write("Time:"+ DateTime.Now + " - Deleted:" + a);
             input = new MindTarget() { Id = 4, Target = "Connection test 2" };
            var b = db.InsertMindTarget(input);
            Console.Write("\nTime:" + DateTime.Now + " - Inserted ID:" + b);
        }

        [TestMethod]
        public void CheckTargetDatabase()
        {
            IDb db = new Db(GetDb);
            MindTarget input2 = new MindTarget() { Target = "testme" };
            int a = db.InsertMindTarget(input2);
            Console.Write("\nTime:" + DateTime.Now + " - Inserted ID:" + a);

            object input = new { Id = a, Target = "For Update" };
            var b2 = db.UpdateMindTarget(input);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b2);
            var b3 = db.SelectMindTarget(input).FirstOrDefault();
            input = new { Id = a, Target = "Updated" };
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + b3.Id + " " + b3.Target);
            var b = db.UpdateMindTarget(input);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b );
            var c = db.SelectMindTarget(input).FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + c.Id + " " + c.Target);
        }


        [TestMethod]
        public void CheckReceivedData()
        {
            IDb db = new Db(GetDb);
            MindTrainedData input = new MindTrainedData() {  Target = 4, Approved = false, Details = "Test Details", Title = "Test Title" };
            var b = db.InsertMindTrainedData(input);
            Console.Write("\nTime:" + DateTime.Now + " - Inserted ID:" + b);
            object input2 = new { Id = b };
            var a2 = db.SelectMindTrainedData().FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select :" + a2.Id + " " + a2.Details);
            object input3 = new { Id = b, Target = 4, Approved = false, Details = "Updated", Title = "For Updated" };
            var a3 = db.UpdateMindTrainedData(input3);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + a3);
            input = new MindTrainedData() { Id = b, Target = 4, Approved=false ,Details=null,Title=null };
            var a = db.DeleteMindTrainedData(input);
            Console.Write("Time:" + DateTime.Now + " - Deleted:" + a);
        }

        [TestMethod]
        public void CheckedTrainedData()
        {
            IDb db = new Db(GetDb);
            MindReceivedData input = new MindReceivedData() {  MaxTarget = 7, Details = "Test Details", Title = "Test Title", Score = 4 };
            var b = db.InsertMindReceivedData(input);
            Console.Write("\nTime:" + DateTime.Now + " - Inserted:" + b);
            object input2 = new { Id = b };
            var b2 = db.SelectMindReceivedData(input2).FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + b2.Id + " " + b2.Details);
            input2 = new { Id = b, MaxTarget = 7, Details = "For Update", Title = "For Update", Score = 0 };
            var b3 = db.UpdateMindReceivedData(input2);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b3);

            input = new MindReceivedData() { Id = 4,  MaxTarget = 7, Details = null, Title = null, Score = 0 };
            var a = db.DeleteMindReceivedData(input);
            Console.Write("Time:" + DateTime.Now + " - Deleted:" + a);

        }

    }
}
