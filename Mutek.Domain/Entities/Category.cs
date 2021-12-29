using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mutek.Domain.Entities
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {
            ProductTypes = new HashSet<ProductType>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 0)]
        public string Title { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<ProductType> ProductTypes { get; set; }
    }
}
