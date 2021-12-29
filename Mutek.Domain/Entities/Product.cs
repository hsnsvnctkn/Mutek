using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mutek.Domain.Entities
{
    [Table("Products")]
    public class Product
    {
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
            ColorOptions = new HashSet<ColorOption>();
            DeliveryProductInfos = new HashSet<DeliveryProductInfo>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 0)]
        public string Title { get; set; }

        public decimal? Height { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Length { get; set; }

        public bool IsShowCase { get; set; }

        public decimal? Price { get; set; }

        public decimal? CustomerPrice { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [StringLength(400, MinimumLength = 0)]
        public string Explanation { get; set; }

        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }

        public virtual ICollection<ColorOption> ColorOptions { get; set; }

        public int BusinessParterId { get; set; }
        public virtual BusinessPartner BusinessPartner { get; set; }

        public virtual ICollection<DeliveryProductInfo> DeliveryProductInfos { get; set; }
    }
}
