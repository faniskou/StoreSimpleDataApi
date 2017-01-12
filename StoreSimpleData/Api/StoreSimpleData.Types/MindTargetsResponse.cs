using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StoreSimpleData.Types
{
    public class MindTargetsResponse
    {
        [DataMember(Name = "mindTargets")]
        public List<MindTarget> MindTargets { get; set; }
    }
}