using MRAShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MRAShop.Model.Models
{
    [Table("Menus")]
    public class Menu:ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        [Required]
        public int GroupID { set; get; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }

        [MaxLength(10)]
        public string Target { set; get; }

        public bool Status { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    }
}