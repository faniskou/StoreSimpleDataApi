using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.ExternalStorage
{
    public class MindReceivedData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Details { get; set; }
        public string Title { get; set; }
        public float Score { get; set; }
        public int MaxTarget { get; set; }
      }
}
