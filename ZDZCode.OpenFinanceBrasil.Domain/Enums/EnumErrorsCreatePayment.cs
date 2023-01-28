using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Códigos de erros previstos na criação da iniciação de pagamento
    /// </summary>
    public enum EnumErrorsCreatePayment
    {
        /// <summary>
        /// Esta conta não possui saldo suficiente para realizar o pagamento.
        /// </summary>
        [Description("Esta conta não possui saldo suficiente para realizar o pagamento")]
        SALDO_INSUFICIENTE = 1,

        /// <summary>
        ///  O beneficiário informado no consentimento não é o mesmo do esperado pelo DICT.
        /// </summary>
        [Description(" O beneficiário informado no consentimento não é o mesmo do esperado pelo DICT")]
        BENEFICIARIO_INCOMPATIVEL = 2,

        /// <summary>
        /// O valor informado no consentimento não é o mesmo valor do informado no payload de pagamento.
        /// </summary>
        [Description("O valor informado no consentimento não é o mesmo valor do informado no payload de pagamento")]
        VALOR_INCOMPATIVEL = 3,

        /// <summary>
        /// O valor (ou quantidade de transações) ultrapassa a faixa de limite parametrizada na detentora para permitir a realização de transações pelo cliente.
        /// </summary>
        [Description("O valor (ou quantidade de transações) ultrapassa a faixa de limite parametrizada na detentora para permitir a realização de transações pelo cliente.")]
        VALOR_ACIMA_LIMITE = 4,

        /// <summary>
        /// O valor enviado não é válido para o QR Code informado.
        /// </summary>
        [Description("O valor enviado não é válido para o QR Code informado")]
        VALOR_INVALIDO = 5,

        /// <summary>
        /// Validação de expiração, validação de vencimento, Status Válido.
        /// </summary>
        [Description("Validação de expiração, validação de vencimento, Status Válido")]
        COBRANCA_INVALIDA = 6,

        /// <summary>
        /// Consentimento inválido (status não é "authorised" ou está expirado).
        /// </summary>
        [Description("Consentimento inválido (status não é 'authorised' ou está expirado)")]
        CONSENTIMENTO_INVALIDO = 7,

        /// <summary>
        /// Requisição está fora da janela de funcionamento.
        /// </summary>
        [Description("Requisição está fora da janela de funcionamento")]
        JANELA_OPER_INVALIDA = 8,

        /// <summary>
        /// Não informada pela detentora de conta.
        /// </summary>
        [Description("Não informada pela detentora de conta")]
        NAO_INFORMADO = 9,

        /// <summary>
        /// Dados do pagamento divergentes dos dados do consentimento.
        /// </summary>
        [Description("Dados do pagamento divergentes dos dados do consentimento")]
        PAGAMENTO_DIVERGENTE_DO_CONSENTIMENTO = 10,
    }
}
