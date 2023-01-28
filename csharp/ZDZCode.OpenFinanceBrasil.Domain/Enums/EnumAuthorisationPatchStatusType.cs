using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Estado para o qual deve ir. [Restrição] O único valor válido é REVOKED. (caso contrário a detentora deve retornar erro HTTP 400)
    /// </summary>
    public enum EnumAuthorisationPatchStatusType
    {
        /// <summary>
        /// Estado para o qual deve ir.
        /// </summary>
        [Description("REVOKED")]
        REVOKED = 1,
    }
}
