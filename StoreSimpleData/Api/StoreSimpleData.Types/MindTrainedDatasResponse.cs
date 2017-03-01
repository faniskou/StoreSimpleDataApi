using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StoreSimpleData.Types
{
    public class MindTrainedDatasResponse
    {
        [DataMember(Name = "MindTrainedDatas")]
        public List<MindTrainedData> MindTrainedDatas { get; set; }
    }
}
