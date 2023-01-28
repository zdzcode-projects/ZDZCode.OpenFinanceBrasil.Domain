using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Especifica a forma de iniciação do pagamento
    /// </summary>
    public enum EnumLocalInstrument
    {
        /// <summary>
        /// Inserção manual de dados da conta transacional
        /// </summary>
        [Description("Inserção manual de dados da conta transacional")]
        MANU = 1,

        /// <summary>
        /// Inserção manual de chave Pix
        /// </summary>
        [Description("Inserção manual de chave Pix")]
        DICT = 2,

        /// <summary>
        /// QR code dinâmico
        /// </summary>
        [Description("QR code dinâmico")]
        QRDN = 3,

        /// <summary>
        /// QR code estático
        /// </summary>
        [Description("QR code estático")]
        QRES = 4,

        /// <summary>
        /// Indica que o recebedor (creditor) contratou o Iniciador de Pagamentos especificamente para realizar iniciações de pagamento em que o beneficiário é previamente conhecido.
        /// </summary>
        [Description("Indica que o recebedor (creditor) contratou o Iniciador de Pagamentos especificamente para realizar iniciações de pagamento em que o beneficiário é previamente conhecido.")]
        INIC = 5,
    }
}
