using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutek.Domain.Entities
{
    [Table("Costs")]
    public class Cost
    {
        public int Id { get; set; }

        public decimal CostPrice { get; set; }

        [StringLength(400, MinimumLength = 0)]
        public string Explanation { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int CostTypeId { get; set; }
        public virtual CostType CostType { get; set; }
    }
}
