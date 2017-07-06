
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship.Models
{
    public class LearningObjective
    {
        [Key]
        public int Id { get; set; }
        
        public string MeasureableLearningObjective1 { get; set; }
        public double SupervisorsRatingOfLearningObjective1 { get; set; }


        public string  MeasureableLearningObjective2 { get; set; }
        public double supervisorsRatingOfLearningObjective2 { get; set; }

        public string MeasureableLearningObjective3 { get; set; }
        public double SupervisorsRatingOfLearningObjective3 { get; set; }

    }
}