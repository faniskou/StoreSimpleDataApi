using StoreSimpleData.Interfaces;
using StoreSimpleData.Types;
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
        //test
        [ActionName("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hi";
        }
        //selects
        [ActionName("selectMindTarget")]
        [HttpGet]
        public MindTargetsResponse SelectMindTarget()
        {
            return service.SelectMindTarget();
        }
        [ActionName("selectMindTarget")]
        [HttpPost]
        public MindTargetsResponse SelectMindTarget(MindTarget inp)
        {
            return service.SelectMindTarget(inp);
        }
        [ActionName("selectMindReceivedData")]
        [HttpGet]
        public MindReceivedDatasResponse SelectMindReceivedData()
        {
            return service.SelectMindReceivedData();
        }
        [ActionName("selectMindReceivedData")]
        [HttpPost]
        public MindReceivedDatasResponse SelectMindReceivedData(MindReceivedData inp)
        {
            return service.SelectMindReceivedData(inp);
        }
        [ActionName("selectMindDerivedData")]
        [HttpGet]
        public MindDerivedDatasResponse SelectMindDerivedData()
        {
            return service.SelectMindDerivedData();
        }
        [ActionName("selectMindDerivedData")]
        [HttpPost]
        public MindDerivedDatasResponse SelectMindDerivedData(MindDerivedData inp)
        {
            return service.SelectMindDerivedData(inp);
        }
        //inserts
        [ActionName("insertMindTarget")]
        [HttpPut]
        public AffectedResponse InsertMindTarget(MindTarget MindTarget)
        {
            return service.InsertMindTarget(MindTarget);
        }
        [ActionName("insertMindReceivedData")]
        [HttpPut]
        public AffectedResponse InsertMindReceivedData(MindReceivedData MindReceivedData)
        {
            return service.InsertMindReceivedData(MindReceivedData);
        }
        [ActionName("insertMindDerivedData")]
        [HttpPut]
        public AffectedResponse InsertMindDerivedData(MindDerivedData MindDerivedData)
        {
            return service.InsertMindDerivedData(MindDerivedData);
        }
        //deletes
        [ActionName("deleteMindTarget")]
        [HttpDelete]
        public AffectedResponse DeleteMindTarget(MindTarget MindTarget)
        {
            return service.DeleteMindTarget(MindTarget);
        }
        [ActionName("deleteMindReceivedData")]
        [HttpDelete]
        public AffectedResponse DeleteMindReceivedData(MindReceivedData MindReceivedData)
        {
            return service.DeleteMindReceivedData(MindReceivedData);
        }
        [ActionName("deleteMindDerivedData")]
        [HttpDelete]
        public AffectedResponse DeleteMindDerivedData(MindDerivedData MindDerivedData)
        {
            return service.DeleteMindDerivedData(MindDerivedData);
        }


    }
}
