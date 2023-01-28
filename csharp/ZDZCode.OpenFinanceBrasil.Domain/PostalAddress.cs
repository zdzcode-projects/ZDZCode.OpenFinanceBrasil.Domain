using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PostalAddress
    {
        /// <summary>
        /// Informação referente ao endereço
        /// </summary>
        [Required]
        public string address { get; set; }

        /// <summary>
        /// Complemento
        /// </summary>
        public string? additionalInfo { get; set; }

        /// <summary>
        /// Bairro
        /// </summary>
        [Required]
        public string districtName { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        [Required]
        public string townName { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        [Required]
        public string countrySubDivision { get; set; }

        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string postCode { get; set; }

    }
}
