using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mutek.Domain.Entities
{
    [Table("RelatedPersons")]
    public class RelatedPerson
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 0)]
        public string FullName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 0)]
        public string PhoneNo { get; set; }

        [StringLength(400, MinimumLength = 0)]
        public string Explanation { get; set; }

        public int BusinessPartnerId { get; set; }
        public virtual BusinessPartner BusinessPartner { get; set; }
    }
}
