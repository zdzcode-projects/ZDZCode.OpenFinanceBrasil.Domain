using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalContacts
    {
        /// <summary>
        /// Lista de endereços da pessoa natural.
        /// </summary>
        [Required]
        public List<PersonalPostalAddress> PostalAddresses { get; set; }

        /// <summary>
        /// Lista com telefones de contato da pessoa natural.
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
