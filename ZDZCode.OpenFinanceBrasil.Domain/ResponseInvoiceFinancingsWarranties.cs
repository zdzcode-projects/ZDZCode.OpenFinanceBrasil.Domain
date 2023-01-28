using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseInvoiceFinancingsWarranties
    {
        /// <summary>
        /// Conjunto de informações referentes às garantias que avalizam a operação de direitos creditórios descontados contratada
        /// </summary>
        [Required]
        public List<InvoiceFinancingsContractedWarranty> Data { get; set; }

        /// <summary>
        /// Referências para outros recusos da API requisitada.
        /// </summary>
        [Required]
        public Links Links { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        [Required]
        public Meta Meta { get; set; }
    }
}
