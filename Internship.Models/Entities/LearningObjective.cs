
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship.Models
{
    public class LearningObjective
    {
        [Key]
        public int Id { get; set; }

        // We link to Cpt applications with this foreign key:
        //public int CptApplicationId { get; set; }
        //[ForeignKey("CptApplicationId")]
        //public virtual CptApplication CptApplication { get; set; }
        
        public string MeasureableLearningObjective { get; set; }
        public double SupervisorRating { get; set; }

    }
}