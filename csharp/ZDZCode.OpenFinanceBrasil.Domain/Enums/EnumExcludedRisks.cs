using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Listagem para indicar quais serão o(s) risco(s) excluído(s) aplicável(is) à(s) cobertura(s).
    /// </summary>
    public enum EnumExcludedRisks
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ATO_RECONHECIMENTO_PERIGOSO = 1,
        
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        ATO_ILICITO_DOLOSO_PRATICADO_SEGURADO = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        OPERACOES_GUERRA = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        FURACOES_CICLONES_TERREMOTOS = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        MATERIAL_NUCLEAR = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        DOENCAS_LESOES_PREEXISTENTES = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        EPIDEMIAS_PANDEMIAS = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        SUICIDIO = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        ATO_ILICITO_DOLOSO_PRATICADO_CONTROLADOR = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        OUTROS = 10,
    }
}
