using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentIMS.Models
{
    public class UnapprovedSelections
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
    }
}
