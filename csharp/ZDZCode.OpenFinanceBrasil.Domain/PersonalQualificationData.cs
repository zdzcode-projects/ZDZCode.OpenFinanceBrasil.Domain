using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalQualificationData
    {
        /// <summary>
        /// Data e hora da atualização do bloco, conforme especificação RFC-3339
        /// </summary>
        [Required]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Número completo do CNPJ da instituição responsável pelo Cadastro - o CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara
        /// </summary>
        [Required]
        public string CompanyCnpj { get; set; }

        /// <summary>
        /// Traz a relação dos códigos relativos à ocupação.
        /// </summary>
        [Required]
        public string OccupationCode { get; set; }

        /// <summary>
        /// Campo livre, de preenchimento obrigatório. Traz o código da ocupação ou o descritivo da ocupação, se selecionada a opção 'OUTRO'
        /// </summary>
        [Required]
        public string OccupationDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InformedIncome InformedIncome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InformedPatrimony InformedPatrimony { get; set; }
    }
}
