using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conjunto de informações referentes à identificação da operação de crédito de financiamento.
    /// </summary>
    public class FinancingsWarranties
    {
        /// <summary>
        /// Moeda referente ao valor da garantia, segundo modelo ISO-4217. p.ex. 'BRL'. Todos os valores monetários informados estão representados com a moeda vigente do Brasil.
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Denominação/Identificação do tipo da garantia que avaliza a Modalidade da Operação de Crédito contratada (Doc 3040, Anexo 12).
        /// </summary>
        [Required]
        public EnumWarrantyType WarrantyType { get; set; }

        /// <summary>
        /// Denominação/Identificação do sub tipo da garantia que avaliza a Modalidade da Operação de Crédito contratada (Doc 3040, Anexo 12).
        /// </summary>
        [Required]
        public EnumWarrantySubType WarrantySubType { get; set; }

        /// <summary>
        /// Valor original da garantia. Valor monetário, expresso com até 4 casas decimais.
        /// </summary>
        [Required]
        public double WarrantyAmount { get; set; }
    }
}
