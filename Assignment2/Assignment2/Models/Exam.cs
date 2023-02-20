using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Exam
    {
        public long ExamId { get; set; }

        [Range(0, 100)]
        public int Score { get; set; }
        public long StudentId { get; set; }
        public int SubjectId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
