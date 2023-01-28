using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumCapitalizationBondsProductModality
    {
        /// <summary>
        /// A modalidade tradicional tem por objetivo restituir ao titular, ao final do prazo de vigência, no mínimo, o valor total das contribuições efetuadas pelo subscritor, desde que todas as contribuições previstas tenham sido realizadas nas datas programadas. (Res CNSP 384/20)
        /// </summary>
        [Description("modalidade tradicional")]
        TRADICIONAL = 1,

        /// <summary>
        /// A modalidade tem por objetivo propiciar que a provisão matemática para capitalização do título de capitalização seja utilizada para assegurar o cumprimento de obrigação assumida em contrato principal pelo titular perante terceiro. (Res CNSP 384/20)
        /// </summary>
        [Description("modalidade INSTRUMENTO GARANTIA")]
        INSTRUMENTO_GARANTIA = 2,

        /// <summary>
        /// A modalidade compra programada garante o valor de resgate em moeda corrente nacional, sendo disponibilizada ao assim desejar e sem qualquer outro custo, pelo recebimento do bem e/ou serviço referenciado no subsidiado por acordos comerciais celebrados com indústrias, atacadistas, empresas comerciais ou prestadores de serviço. (Res CNSP 384/20)
        /// </summary>
        [Description("modalidade compra programada")]
        COMPRA_PROGRAMADA = 3,

        /// <summary>
        /// A modalidade popular tem por objetivo propiciar a capitalização da contribuição e a participação do titular em sorteios, sem que haja devolução integral do valor pago. (Res CNSP 384/20)
        /// </summary>
        [Description("modalidade popular")]
        POPULAR = 4,

        /// <summary>
        /// A modalidade incentivo tem por objetivo a vinculação a um evento promocional de caráter comercial instituído pelo subscritor para alavancar a venda de seu(s) produto(s) ou serviços ou para fidelizar seus clientes. (Res CNSP 384/20)
        /// </summary>
        [Description("modalidade incentivo")]
        INCENTIVO = 5,

        /// <summary>
        /// A modalidade filantropia premiável é destinada ao subscritor interessado em contribuir com entidades beneficentes de assistências sociais, certificadas nos termos da legislação vigente, e participar de sorteio(s). (Res CNSP 384/20)
        /// </summary>
        [Description("modalidade filantropia")]
        FILANTROPIA_PREMIAVEL = 6,


    }
}
