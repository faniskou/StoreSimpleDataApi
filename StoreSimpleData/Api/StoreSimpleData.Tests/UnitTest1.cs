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
    }
}
