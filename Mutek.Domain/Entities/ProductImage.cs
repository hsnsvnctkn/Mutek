using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mutek.Domain.Entities
{
    [Table("ProductImages")]
    public class ProductImage
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 0)]
        public string Url { get; set; }

        public virtual Product Product { get; set; }
    }
}
