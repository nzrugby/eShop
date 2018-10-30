using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IProduct
    {
        Guid Id { get; set; }
        string Category { get; set; }
        string Name { get; set; }
        int Qty { get; set; }
        decimal Price { get; set; }
        string Description { get; set; }
    }
}
