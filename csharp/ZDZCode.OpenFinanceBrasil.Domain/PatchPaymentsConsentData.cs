using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PatchPaymentsConsentData
    {
        /// <summary>
        /// Estado para o qual deve ir. [Restrição] O único valor válido é REVOKED. (caso contrário a detentora deve retornar erro HTTP 400)
        /// </summary>
        [Required]
        public EnumAuthorisationPatchStatusType Status { get; set; }

        /// <summary>
        /// Objeto que contém as informações das circunstância da revogação. [Restrição] O campo loggedUser deve ser preenchido quando a revogação for feita pelo usuário final, ou seja, se o campo data.revocation.revokedBy estiver com o valor 'USER'.
        /// </summary>
        [Required]
        public Revocation Revocation { get; set; }
    }
}
