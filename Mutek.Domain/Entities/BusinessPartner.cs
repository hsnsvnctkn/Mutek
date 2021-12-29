using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mutek.Domain.Entities
{
    [Table("BusinessPartnes")]
    public class BusinessPartner
    {
        public BusinessPartner()
        {
            RelatedPersons = new HashSet<RelatedPerson>();
            DeliveryProductInfos = new HashSet<DeliveryProductInfo>();
            Deliveries = new HashSet<Delivery>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 0)]
        public string FullName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 0)]
        public string PhoneNo { get; set; }

        [StringLength(100, MinimumLength = 0)]
        public string TaxAdministration { get; set; }

        [StringLength(100, MinimumLength = 0)]
        public string TaxNo { get; set; }

        [StringLength(400, MinimumLength = 0)]
        public string Explanation { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<RelatedPerson> RelatedPersons { get; set; }

        public int BusinessPartnerTypeId { get; set; }
        public virtual BusinessPartnerType BusinessPartnerType { get; set; }

        public virtual ICollection<DeliveryProductInfo> DeliveryProductInfos { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; }

    }
}
