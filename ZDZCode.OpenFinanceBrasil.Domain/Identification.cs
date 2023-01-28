using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Objeto contendo os dados do recebedor (creditor).
    /// </summary>
    public class Identification
    {
        /// <summary>
        /// Titular, pessoa natural ou juridica a quem se referem os dados de recebedor (creditor).
        /// </summary>
        [Required]
        public EnumPaymentPersonType PersonType { get; set; }

        /// <summary>
        /// 	Identificação da pessoa envolvida na transação. Preencher com o CPF ou CNPJ, de acordo com o valor escolhido no campo type. O CPF será utilizado com 11 números e deverá ser informado sem pontos ou traços. O CNPJ será utilizado com 14 números e deverá ser informado sem pontos ou traços.
        /// </summary>
        [Required]
        public string CpfCnpj { get; set; }

        /// <summary>
        /// Em caso de pessoa natural deve ser informado o nome completo do titular da conta do recebedor. Em caso de pessoa jurídica deve ser informada a razão social ou o nome fantasia da conta do recebedor.
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
