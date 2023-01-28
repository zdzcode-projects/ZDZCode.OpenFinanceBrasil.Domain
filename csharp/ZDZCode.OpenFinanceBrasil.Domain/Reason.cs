using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Reason
    {
        /// <summary>
        /// Define o código da razão pela qual o consentimento foi revogado.
        /// Valores possíveis: 
        ///FRAUD - Indica suspeita de fraude
        ///ACCOUNT_CLOSURE - Indica que a conta do usuário foi encerrada
        ///OTHER - Indica que motivo do cancelamento está fora dos motivos pré-estabelecidos.
        /// </summary>
        [Required]
        public EnumRevocationReason Code { get; set; }

        /// <summary>
        /// Contém informações adicionais definidas pelo requisitante da revogação. [Restrição] Deverá ser obrigatoriamente preenchido quando a revogação for feita pela iniciadora ou pela detentora unilateralmente, ou seja, quando o campo revokedBy for igual a TPP ou ASPSP e o motivo de revogação for OTHER.
        /// </summary>
        public string AdditionalInformation { get; set; }
    }
}
