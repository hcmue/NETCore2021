using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreLab.Entities
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int MaLoai { get; set; }
        [MaxLength(100)]
        [Required]
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public ICollection<HangHoa> HangHoas { get; set; }
        public Loai()
        {
            HangHoas = new HashSet<HangHoa>();
        }
    }
}
