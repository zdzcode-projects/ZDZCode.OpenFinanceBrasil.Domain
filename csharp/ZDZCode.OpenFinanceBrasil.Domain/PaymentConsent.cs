using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class PaymentConsent
    {
        /// <summary>
        /// Este campo define o tipo de pagamento que será iniciado após a autorização do consentimento.
        /// </summary>
        [Required]
        public EnumPaymentType Type { get; set; }

        /// <summary>
        /// Mutuamente exclusivo com o campo date. Este campo é obrigatório no caso de agendamento. Neste caso, o campo date não deve ser informado.
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Mutuamente exclusivo com o objeto schedule. Este campo é obrigatório no caso de pagamento único. Neste caso, o objeto schedule não deve ser informado.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Código da moeda nacional segundo modelo ISO-4217, ou seja, 'BRL'.Todos os valores monetários informados estão representados com a moeda vigente do Brasil.
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Valor da transação com 2 casas decimais.
        /// </summary>
        [Required]
        public string Amount { get; set; }

        /// <summary>
        /// Traz o código da cidade segundo o IBGE (Instituto Brasileiro de Geografia e Estatística). Para o preenchimento deste campo, o Iniciador de Pagamentos deve seguir a orientação do arranjo da forma de pagamento. O preenchimento do campo tanto em pix/payments quanto /consents deve ser igual.Caso haja divergência dos valores, a instituição deve retornar HTTP 422 com o código de erro PAGAMENTO_DIVERGENTE_DO_CONSENTIMENTO. Este campo faz referência ao campo CodMun do arranjo Pix.
        /// </summary>
        public string IbgeTownCode { get; set; }

        /// <summary>
        /// Objeto contendo os detalhes do pagamento.
        /// </summary>
        [Required]
        public Details Details { get; set; }
    }
}
