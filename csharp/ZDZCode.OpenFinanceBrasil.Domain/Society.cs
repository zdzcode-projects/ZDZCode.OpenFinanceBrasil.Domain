using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conjunto de informações relativas à seguradora do produto de open insurance.
    /// </summary>
    public class Society
    {
        /// <summary>
        /// Nome da Sociedade Seguradora.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// O CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara.
        /// </summary>
        [Required]
        public CnpjNumber CnpjNumber { get; set; }
    }
}
