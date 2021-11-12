using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace dapperclass.Models
{
    [Table("Categories")]
    public class Category:MyEntity<Category>
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name  { get; set; }

        [Write(false)]
        public List<Product> Products { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
