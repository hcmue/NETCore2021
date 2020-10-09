using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class StudentInfo
    {
        [Display(Name="Mã sinh viên")]
        [MaxLength(10, ErrorMessage ="10 kí tự")]
        public string Id { get; set; }

        [Display(Name="Họ tên sinh viên")]
        [Required]
        public string Name { get; set; }

        [Display(Name="Điểm")]
        [Range(0, 10)]
        public double GPA { get; set; }
    }
}
