using MRAShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MRAShop.Model.Models
{
    [Table("Orders")]
    public class Order : ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMobile { set; get; }
        [Required]
        [MaxLength(256)]

        public string CustomerMessage { set; get; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }//1 order có thể chứa nhiều orderdetail
    }
}