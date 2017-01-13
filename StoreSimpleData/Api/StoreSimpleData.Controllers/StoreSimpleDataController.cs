using Data.ExternalStorage;
using StoreSimpleData.Interfaces;
using System.Configuration;
using System.Web.Http;

namespace StoreSimpleData.Controllers
{
    public class StoreSimpleDataController : ApiController
    {
        readonly IStoreSimpleData service;
        public StoreSimpleDataController(IStoreSimpleData serv)
        {
            //   string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            //   IStoreSimpleData serv = new StoreSimpleData(dbcon);
            service = serv;
        }

        [ActionName("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hi";
        }
        [ActionName("selectMindTarget")]
        [HttpGet]
        public Types.MindTargetsResponse SelectMindTarget()
        {
            return service.SelectMindTarget();
        }

    }
}
