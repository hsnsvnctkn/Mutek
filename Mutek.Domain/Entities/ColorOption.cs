using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mutek.Domain.Entities
{
    [Table("ColorOptions")]
    public class ColorOption
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 0)]
        public string Title { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual Product Product { get; set; }
    }
}
