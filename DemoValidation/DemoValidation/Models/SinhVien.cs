using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoValidation.Models
{
    public class SinhVien
    {
        [Display(Name ="Họ tên")]
        [Required(ErrorMessage ="*")]
        public string HoTen { get; set; }

        [Display(Name = "Tuổi")]
        [Range(18, 60, ErrorMessage ="Tuổi từ 18 - 60")]
        public int Tuoi { get; set; }
    }
}
