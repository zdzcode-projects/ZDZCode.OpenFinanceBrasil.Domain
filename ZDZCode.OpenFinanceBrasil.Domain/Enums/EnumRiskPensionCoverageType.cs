using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// É o conjunto dos riscos cobertos elencados na apólice. (RESOLUÇÃO CNSP Nº 341/2016). Listagem de coberturas incluídas no produto que deve observar a relação discriminada de coberturas, conforme Tabela Tipo de Cobertura.
    /// </summary>
    public enum EnumRiskPensionCoverageType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        MORTE = 1,
        /// <summary>
        ///  
        /// </summary>
        [Description(" ")]
        INVALIDEZ = 2,

        /// <summary>
        ///  
        /// </summary>
        [Description(" ")]
        OUTROS = 3,
    }
}
