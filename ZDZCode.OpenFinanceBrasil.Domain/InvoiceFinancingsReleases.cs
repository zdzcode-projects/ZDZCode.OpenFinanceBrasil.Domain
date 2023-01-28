using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvoiceFinancingsReleases
    {
        public string PaymentId { get; set; }
        public bool IsOverParcelPayment { get; set; }
        public string InstalmentId { get; set; }
        public string PaidDate { get; set; }
        public string Currency { get; set; }
        public double PaidAmount { get; set; }
        public OverParcel OverParcel { get; set; }
    }
}
