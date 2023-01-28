using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BusinessOtherDocument
    {
        /// <summary>
        /// Número do Tipo de documento informado. De preenchimento obrigatório, para a Pessoa jurídica com domicílio ou sede no exterior, desobrigada de inscrição no CNPJ.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Número do outro documento. De preenchimento obrigatório, para a Pessoa jurídica com domicílio ou sede no exterior, desobrigada de inscrição no CNPJ.
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Pais de emissão do tipo de documento informado. Código do pais de acordo com o código “alpha3” do ISO-3166.
        /// </summary>
        [Required]
        public string Country { get; set; }

        /// <summary>
        /// Data vigência do tipo de documento informado, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public string ExpirationDate { get; set; }
    }
}
