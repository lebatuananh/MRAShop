using MRAShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MRAShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : ISeoable, IAuditable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }
        public bool Status { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual IEnumerable<Product> Products { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }
    }
}