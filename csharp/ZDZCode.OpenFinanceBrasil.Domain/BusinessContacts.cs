using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conjunto de informações referentes às formas para contatar o cliente.
    /// </summary>
    public class BusinessContacts
    {
        /// <summary>
        /// Lista de endereços da pessoa jurídica.
        /// </summary>
        [Required]
        public List<BusinessPostalAddress> PostalAddresses { get; set; }

        /// <summary>
        /// Lista com telefones de contato da pessoa jurídica.
        /// </summary>
        [Required]
        public List<CustomerPhone> Phones { get; set; }

        /// <summary>
        /// Lista e-mails de contato.
        /// </summary>
        [Required]
        public List<CustomerEmail> Emails { get; set; }
    }
}
