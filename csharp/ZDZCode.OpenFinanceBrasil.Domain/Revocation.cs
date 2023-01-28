using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Revocation
    {
        /// <summary>
        /// Usuário (pessoa natural) que encontra-se logado na instituição Iniciadora de Pagamento. [Restrição] Deve obrigatoriamente ser enviado quando a revogação for feita pelo usuário final, ou seja, se o campo revokedBy estiver com o valor 'USER'.
        /// </summary>
        public LoggedUser LoggedUser { get; set; }

        /// <summary>
        /// Define qual das partes envolvidas na transação está realizando a revogação. Valores possíveis:
        ///- USER(Revogado pelo usuário)
        ///- ASPSP(Provedor de serviços de pagamento para serviços de conta - Detentora de conta)
        ///- TPP(Instituições Provedoras - iniciadora de pagamentos)
        /// </summary>
        [Required]
        public EnumRevokedBy RevokedBy { get; set; }

        /// <summary>
        /// Define a razão pela qual o consentimento foi revogado.
        /// </summary>
        [Required]
        public Reason Reason { get; set; }
    }
}
