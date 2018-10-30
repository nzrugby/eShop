using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo
{
    public class EShopDbContext:DbContext
    {
        public DbSet<IUser> Users { get; set; }
        public DbSet<IProduct> Products { get; set; }
        public DbSet<IOrder> Orders { get; set; }
        public DbSet<IShopCart> ShopCarts { get; set; }
    }
}
