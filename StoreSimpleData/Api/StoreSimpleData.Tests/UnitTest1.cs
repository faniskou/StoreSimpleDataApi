using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.ExternalStorage;
using System.Linq;


namespace StoreSimpleData.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConnectToDatabase()
        {
            IDb db = new Db("");
            MindName input = new MindName() { Id = 4, Name = null };
            var a = db.DeleteMindName(input);
            Console.Write("Time:"+ DateTime.Now + " - Deleted:" + a);
             input = new MindName() { Id = 4, Name = "Connection test 2" };
            var b = db.InsertMindName(input);
            Console.Write("\nTime:" + DateTime.Now + " - Inserted:" + b);
        }
        [TestMethod]
        public void SelectPrintFirstDatabase()
        {
            IDb db = new Db("");
            object input = new  { Id = 4 };
            var a = db.SelectMindName().FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + a.Id + " " + a.Name);
            var b= db.SelectMindName(input).FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + b.Id + " " + b.Name);
        }
        [TestMethod]
        public void UpdateFirstDatabase()
        {
            IDb db = new Db("");
            object input = new { Id = 4, Name = "For Update" };
            var b2 = db.UpdateMindName(input);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b2);
            var a = db.SelectMindName(input).FirstOrDefault();
            input = new { Id = 4, Name = "Updated" };
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + a.Id + " " + a.Name);
            var b = db.UpdateMindName(input);
            Console.Write("\nTime:" + DateTime.Now + " - Update count:" + b );
            var c = db.SelectMindName(input).FirstOrDefault();
            Console.Write("\nTime:" + DateTime.Now + " - Select:" + c.Id + " " + c.Name);
        }
    }
}
