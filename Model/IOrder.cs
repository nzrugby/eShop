using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public interface IOrder
    {
        Guid Id { get; set; }
        List<IShopCart> ShopCarts { get; set; }

        [ForeignKey("User")]
        Guid UserId { get; set; }
        IUser User { get; set; }
    }
}
