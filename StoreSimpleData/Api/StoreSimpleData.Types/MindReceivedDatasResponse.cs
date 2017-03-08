using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StoreSimpleData.Types
{
    public class MindReceivedDatasResponse
    {
        [DataMember(Name = "MindReceivedDatas")]
        public List<MindReceivedData> MindReceivedDatas { get; set; }
    }
}
