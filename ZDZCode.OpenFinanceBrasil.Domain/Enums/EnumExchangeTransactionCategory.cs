using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// A classificação do tipo de operação, conforme a circular BCB nº 3690 de 16/12/2013.
    /// </summary>
    public enum EnumExchangeTransactionCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        COMERCIO_EXTERIOR = 1,
        
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        TRANSPORTE = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        SEGUROS = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        VIAGENS_INTERNACIONAIS = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        TRANSFERENCIAS_UNILATERAIS = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        SERVICOS_DIVERSOS = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        RENDAS_CAPITAIS = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        CAPITAIS_BRASILEIROS = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        CAPITAIS_ESTRANGEIROS = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        PRESTACAO_SERVICO_PAGAMENTO_OU_TRANSFERENCIA_INTERNACIONAL_EFX = 10,
    }
}
