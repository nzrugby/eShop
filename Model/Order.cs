using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Order:BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public List<ShopCart> ShopCarts { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal TotalPayment { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
