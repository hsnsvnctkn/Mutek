using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Mutek.Shared.Enums;

namespace Mutek.Domain.Entities
{
    [Table("Deliveries")]
    public class Delivery
    {
        public Delivery()
        {
            DeliveryProductInfos = new HashSet<DeliveryProductInfo>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 0)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 0)]
        public string CustomerPhoneNo { get; set; }

        [StringLength(300, MinimumLength = 0)]
        public string Address { get; set; }

        public decimal? ShippingCost { get; set; }

        public decimal? ProductAmount { get; set; }

        public decimal? AmountToBeReflected { get; set; }

        public DeliveryStatus DeliveryStatus { get; set; }

        public PriceType PriceType { get; set; }

        public bool HasPaymentReceived { get; set; }

        [StringLength(400, MinimumLength = 0)]
        public string Explanation { get; set; }

        public DateTime? PlannedDate { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public ICollection<DeliveryProductInfo> DeliveryProductInfos { get; set; }

        public int ShipperId { get; set; }
        public virtual BusinessPartner Shipper { get; set; }

        public virtual Debt Debt { get; set; }
    }
}
