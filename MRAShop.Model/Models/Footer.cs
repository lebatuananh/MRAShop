using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MRAShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key] //khóa chính
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]//bắt buộc phải nhập
        public string Content { set; get; }
    }
}