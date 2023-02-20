using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Student
    {
        public long StudentId { get; set; }

        [StringLength(150, MinimumLength = 8)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual List<Exam>? Exams { get; set; }
    }
}
