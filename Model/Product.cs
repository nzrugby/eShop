using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Product:BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<ProductImage> Images { get; set; }
    }
}
