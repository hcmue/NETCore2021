using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoValidation.Models
{
    public enum Gender
    {
        Nam,
        Nữ
    }

    public class Employee
    {
        public Guid Id { get; set; }

        [Remote(controller:"Demo", action:"KiemTraMaNhanVien")]
        public int EmployeeNo { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Compare("Email")]
        public string ConfirmEmail { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Url]
        public string Website { get; set; }

        [DataType(DataType.Date)]
        [KiemTraTuoi]
        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public double Salary { get; set; }

        public bool IsPartTime { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        [CreditCard]
        public string CreditCard { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(255)]
        public string Description { get; set; }
    }
}
