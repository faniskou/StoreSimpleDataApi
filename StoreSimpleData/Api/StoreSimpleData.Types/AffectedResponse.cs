using System.Runtime.Serialization;

namespace StoreSimpleData.Types
{
    public class AffectedResponse
    {
        [DataMember(Name = "rowsAffected")]
        public int RowsAffected { get; set; }
    }
}
