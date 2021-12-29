using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutek.Domain.Entities
{
    [Table("DebtTypes")]
    public class DebtType
    {
        public DebtType()
        {
            Debts = new HashSet<Debt>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 0)]
        public string Title { get; set; }

        public virtual ICollection<Debt> Debts { get; set; }
    }
}
