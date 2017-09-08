using System.Runtime.Serialization;

namespace StoreSimpleData.Types
{
    public class InsertSingleResponse
    {
        [DataMember(Name = "rowIdAffected")]
        public int RowIdAffected { get; set; }
    }
}
