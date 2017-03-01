using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.ExternalStorage;
using System.Linq;
using System.Configuration;

namespace StoreSimpleData.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ConnectToDatabase()
        {
            string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            IDb db = new Db(dbcon);
            MindTarget input = new MindTarget() { Id = 4, Target = null };
            var a = db.DeleteMindTarget(input);
            Console.Write("Time:"+ DateTime.Now + " - Deleted:" + a);
             input = new MindTarget() { Id = 4, Target = "Connection test 2" };
            var b = db.InsertMindTarget(input);
            Console.Write("\nTime:" + DateTime.Now + " - Inserted:" + b);
        }
        [TestMethod]
        public void SelectPrintFirstDatabase()
        {
            string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            IDb db = new Db(dbcon);
            object input = new  { Id = 4 };
            var a = db.SelectMindTarget().FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + a.Id + " " + a.Target);
            var b= db.SelectMindTarget(input).FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + b.Id + " " + b.Target);
        }
        [TestMethod]
        public void UpdateFirstDatabase()
        {
            string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            IDb db = new Db(dbcon);
            object input = new { Id = 4, Target = "For Update" };
            var b2 = db.UpdateMindTarget(input);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b2);
            var a = db.SelectMindTarget(input).FirstOrDefault();
            input = new { Id = 4, Target = "Updated" };
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + a.Id + " " + a.Target);
            var b = db.UpdateMindTarget(input);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b );
            var c = db.SelectMindTarget(input).FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + c.Id + " " + c.Target);
        }


        [TestMethod]
        public void ConnectToReceivedData()
        {
            string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            IDb db = new Db(dbcon);
            MindReceivedData input = new MindReceivedData() { Id = 4, Target = 4, Approved=false ,Details=null,Title=null };
            var a = db.DeleteMindReceivedData(input);
            Console.Write("Time:" + DateTime.Now + " - Deleted:" + a);
            input = new MindReceivedData() { Id = 4, Target = 4, Approved = false, Details = "Test Details", Title = "Test Title" };
            var b = db.InsertMindReceivedData(input);
            Console.Write("\nTime:" + DateTime.Now + " - Inserted:" + b);
        }
        [TestMethod]
        public void SelectReceivedData()
        {
            string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            IDb db = new Db(dbcon);
            object input = new { Id = 4 };
            var a = db.SelectMindReceivedData().FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + a.Id + " " + a.Details);
            var b = db.SelectMindReceivedData(input).FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + b.Id + " " + b.Details);
        }
        [TestMethod]
        public void UpdateReceivedData()
        {
            string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            IDb db = new Db(dbcon);
            object input = new { Id = 4, Target = 4, Approved = false, Details = "For Update", Title = "For Update" };
            var b2 = db.UpdateMindReceivedData(input);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b2);
            var a = db.SelectMindReceivedData(input).FirstOrDefault();
            input = new { Id = 4, Target = 4, Approved = false, Details = "Updated", Title = "For Updated" };
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + a.Id + " " + a.Details);
            var b = db.UpdateMindReceivedData(input);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b);
            var c = db.SelectMindReceivedData(input).FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + c.Id + " " + c.Details);
        }


        [TestMethod]
        public void ConnectToTrainedData()
        {
            string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            IDb db = new Db(dbcon);
            MindTrainedData input = new MindTrainedData() { Id = 4,  MaxTarget = 7, Details = null, Title = null, Score = 0 };
            var a = db.DeleteMindTrainedData(input);
            Console.Write("Time:" + DateTime.Now + " - Deleted:" + a);
            input = new MindTrainedData() { Id = 4, MaxTarget = 7, Details = "Test Details", Title = "Test Title", Score = 4 };
            var b = db.InsertMindTrainedData(input);
            Console.Write("\nTime:" + DateTime.Now + " - Inserted:" + b);
        }
        [TestMethod]
        public void SelectTrainedData()
        {
            string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            IDb db = new Db(dbcon);
            object input = new { Id = 4 };
            var a = db.SelectMindTrainedData().FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + a.Id + " " + a.Details);
            var b = db.SelectMindTrainedData(input).FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + b.Id + " " + b.Details);
        }
        [TestMethod]
        public void UpdateTrainedData()
        {
            string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            IDb db = new Db(dbcon);
            object input = new { Id = 4, MaxTarget = 7, Details = "For Update", Title = "For Update", Score = 0 };
            var b2 = db.UpdateMindTrainedData(input);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b2);
            var a = db.SelectMindTrainedData(input).FirstOrDefault();
            input = new { Id = 4, MaxTarget = 7, Title = "Updated", Details = "Updated", Score = 0 };
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + a.Id + " " + a.Details);
            var b = db.UpdateMindTrainedData(input);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b);
            var c = db.SelectMindTrainedData(input).FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + c.Id + " " + c.Details);
        }
    }
}
