using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mutek.Domain.Entities
{
    [Table("BusinessPartnerTypes")]
    public class BusinessPartnerType
    {
        public BusinessPartnerType()
        {
            BusinessPartners = new HashSet<BusinessPartner>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 0)]
        public string Title { get; set; }

        public virtual ICollection<BusinessPartner> BusinessPartners { get; set; }
    }
}
