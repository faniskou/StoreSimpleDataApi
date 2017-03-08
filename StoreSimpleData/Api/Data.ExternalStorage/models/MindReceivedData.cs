using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.ExternalStorage
{
    public class MindTrainedData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Target { get; set; }
        public string Details { get; set; }
        public string Title { get; set; }
        public bool Approved { get; set; }
      }
}
