using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;

namespace dapperclass.Models
{
    [Table("Products")]
    public class Product:MyEntity<Product>
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        [Write(false)]
        public Category Category { get; set; }
        public int CategoryFk { get; set; }
    }
}
