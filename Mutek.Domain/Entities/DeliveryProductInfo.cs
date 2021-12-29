using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mutek.Domain.Entities
{
    [Table("DeliveryProductInfos")]
    public class DeliveryProductInfo
    {
        public int Id { get; set; }

        public bool HasInvoiceReceived { get; set; }

        public bool HasInvoiceSend { get; set; }

        public bool HasInvoiceIssued { get; set; }

        public bool HasPaid { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int SupplierId { get; set; }
        public virtual BusinessPartner BusinessPartner { get; set; }

        public int DeliveryId { get; set; }
        public virtual Delivery Delivery { get; set; }

        public int? DebtId { get; set; }
        public Debt Debt { get; set; }
    }
}
