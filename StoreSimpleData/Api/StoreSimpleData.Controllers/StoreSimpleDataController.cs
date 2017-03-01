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
        [ActionName("selectMindTrainedData")]
        [HttpGet]
        public MindTrainedDatasResponse SelectMindTrainedData()
        {
            return service.SelectMindTrainedData();
        }
        [ActionName("selectMindTrainedData")]
        [HttpPost]
        public MindTrainedDatasResponse SelectMindTrainedData(MindTrainedData inp)
        {
            return service.SelectMindTrainedData(inp);
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
        [ActionName("insertMindTrainedData")]
        [HttpPut]
        public AffectedResponse InsertMindTrainedData(MindTrainedData MindTrainedData)
        {
            return service.InsertMindTrainedData(MindTrainedData);
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
        [ActionName("deleteMindTrainedData")]
        [HttpDelete]
        public AffectedResponse DeleteMindTrainedData(MindTrainedData MindTrainedData)
        {
            return service.DeleteMindTrainedData(MindTrainedData);
        }


    }
}
