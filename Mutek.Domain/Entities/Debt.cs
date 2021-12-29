using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutek.Domain.Entities
{
    [Table("Debts")]
    public class Debt
    {
        public Debt()
        {
            DeliveryProductInfos = new HashSet<DeliveryProductInfo>();
        }

        public int Id { get; set; }

        [StringLength(200, MinimumLength = 0)]
        public string CustomerName { get; set; }

        [StringLength(20, MinimumLength = 0)]
        public string CustomerPhoneNo { get; set; }

        [StringLength(300, MinimumLength = 0)]
        public string Address { get; set; }

        public bool HasPaid { get; set; }

        public decimal? SumAmount { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? PaidDate { get; set; }

        [StringLength(400, MinimumLength = 0)]
        public string Explanation { get; set; }

        public int DebtTypeId { get; set; }
        public virtual DebtType DebtType { get; set; }

        public virtual ICollection<DeliveryProductInfo> DeliveryProductInfos { get; set; }

        public int? DeliveryId { get; set; }
        public virtual Delivery Delivery { get; set; }
    }
}
