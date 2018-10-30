using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public interface IShopCart
    {
        Guid Id { get; set; }
        [ForeignKey("Product")]
        Guid ProductId { get; set; }
        IProduct Product { get; set; }
        int Qty { get; set; }

        [ForeignKey("Order")]
        Guid OrderId { get; set; }
        IOrder Order { get; set; }
    }
}
