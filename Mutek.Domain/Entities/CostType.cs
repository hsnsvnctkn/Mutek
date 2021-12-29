using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutek.Domain.Entities
{
    [Table("CostTypes")]
    public class CostType
    {
        public CostType()
        {
            Costs = new HashSet<Cost>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 0)]
        public string Title { get; set; }

        public virtual ICollection<Cost> Costs { get; set; }
    }
}
