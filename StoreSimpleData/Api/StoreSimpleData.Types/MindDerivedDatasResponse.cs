using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StoreSimpleData.Types
{
    public class MindDerivedDatasResponse
    {
        [DataMember(Name = "MindDerivedDatas")]
        public List<MindDerivedData> MindDerivedDatas { get; set; }
    }
}
