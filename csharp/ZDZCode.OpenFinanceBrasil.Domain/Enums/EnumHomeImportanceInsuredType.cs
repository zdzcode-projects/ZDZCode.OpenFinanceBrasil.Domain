using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// A considerar os seguintes domínios abaixo
    /// </summary>
    public enum EnumHomeImportanceInsuredType
    {
        /// <summary>
        /// Prédio
        /// </summary>
        [Description("Prédio")]
        PREDIO = 1,

        /// <summary>
        /// Conteúdo
        /// </summary>
        [Description("Conteúdo")]
        CONTEUDO = 2,

        /// <summary>
        /// Ambos
        /// </summary>
        [Description("Ambos")]
        AMBOS = 3,
    }
}
