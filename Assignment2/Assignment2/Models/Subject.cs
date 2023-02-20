using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        [StringLength(150, MinimumLength = 8)]
        public string SubjectName { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string SubjectCode { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> EndDate { get; set; }

        public virtual List<Exam>? Exams { get; set; }
    }
}
