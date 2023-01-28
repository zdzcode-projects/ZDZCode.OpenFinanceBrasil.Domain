using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Objeto contendo dados do pagamento e do recebedor (creditor).
    /// </summary>
    public class CreatePixPaymentData
    {
        /// <summary>
        ///Especifica a forma de iniciação do pagamento: - MANU - Inserção manual de dados da conta transacional - DICT - Inserção manual de chave Pix - QRDN - QR code dinâmico - QRES - QR code estático - INIC - Indica que o recebedor(creditor) contratou o Iniciador de Pagamentos especificamente para realizar iniciações de pagamento em que o beneficiário é previamente conhecido.
        /// </summary>
        [Required]
        public string LocalInstrument { get; set; }

        /// <summary>
        /// Objeto contendo dados do pagameto como moeda e valor.
        /// </summary>
        [Required]
        public PaymentPix Payment { get; set; }

        /// <summary>
        /// Objeto que contém a identificação da conta de destino do beneficiário/recebedor.
        /// </summary>
        [Required]
        public CreditorAccount CreditorAccount { get; set; }

        /// <summary>
        /// Deve ser preenchido sempre que o usuário pagador inserir alguma informação adicional em um pagamento, a ser enviada ao recebedor.
        /// </summary>
        public string RemittanceInformation { get; set; }

        /// <summary>
        /// Sequência de caracteres que corresponde ao QR Code disponibilizado para o pagador. É a sequência de caracteres que seria lida pelo leitor de QR Code, e deve propiciar o retorno dos dados do pagador após consulta na DICT. Essa funcionalidade é possível tanto para QR Code estático quanto para QR Code dinâmico.
        /// No arranjo do Pix esta é a mesma sequência gerada e/ou lida pela funcionalidade Pix Copia e Cola. Este campo deverá ser no formato UTF-8. [Restrição] Preenchimento obrigatório para pagamentos por QR Code, observado o tamanho máximo de 512 bytes.
        /// </summary>
        public string QrCode { get; set; }

        /// <summary>
        /// Chave cadastrada no DICT pertencente ao recebedor. Os tipos de chaves podem ser: telefone, e-mail, cpf/cnpj ou chave aleatória. No caso de telefone celular deve ser informado no padrão E.1641.Para e-mail deve ter o formato xxxxxxxx@xxxxxxx.xxx(.xx) e no máximo 77 caracteres. No caso de CPF deverá ser informado com 11 números, sem pontos ou traços. Para o caso de CNPJ deverá ser informado com 14 números, sem pontos ou traços.
        /// No caso de chave aleatória deve ser informado o UUID gerado pelo DICT, conforme formato especificado na RFC41223. Se informado, a detentora da conta deve validar o proxy no DICT quando localInstrument for igual a DICT, QRDN ou QRES e validar o campo creditorAccount. Esta validação é opcional caso o localInstrument for igual a INIC. [Restrição] Se localInstrument for igual a MANU, o campo proxy não deve ser preenchido.Se localInstrument for igual INIC, DICT, QRDN ou QRES, o campo proxy deve ser sempre preenchido com a chave Pix.
        /// </summary>
        public string Proxy { get; set; }

        /// <summary>
        /// CNPJ do Iniciador de Pagamento devidamente habilitado para a prestação de Serviço de Iniciação no Pix.
        /// </summary>
        [Required]
        public string CnpjInitiator { get; set; }

        /// <summary>
        /// 	Trata-se de um identificador de transação que deve ser retransmitido intacto pelo PSP do pagador ao gerar a ordem de pagamento. Essa informação permitirá ao recebedor identificar e correlacionar a transferência, quando recebida, com a apresentação das instruções ao pagador. Os caracteres permitidos no contexto do Pix para o campo txid(EMV 62-05) são:
        /// - Letras minúsculas, de ‘a’ a ‘z’
        /// - Letras maiúsculas, de ‘A’ a ‘z’
        /// - Dígitos decimais, de ‘0’ a ‘9’
        /// [Restrição] Se localInstrument for igual a INIC, o campo transactionIdentification deve ser preenchido obrigatoriamente. Se localInstrument for igual a MANU ou DICT, o campo transactionIdentification não deve ser preenchido.  A detentora de conta deve validar se a condicionalidade do campo foi atendida pela iniciadora de pagamento.
        /// </summary>
        public string TransactionIdentification { get; set; }

        /// <summary>
        /// Traz o código da cidade segundo o IBGE (Instituto Brasileiro de Geografia e Estatística). Para o preenchimento deste campo, o Iniciador de Pagamentos deve seguir a orientação do arranjo da forma de pagamento. O preenchimento do campo tanto em pix/payments quanto /consents deve ser igual.Caso haja divergência dos valores, a instituição deve retornar HTTP 422 com o código de erro PAGAMENTO_DIVERGENTE_DO_CONSENTIMENTO. Este campo faz referência ao campo CodMun do arranjo Pix.
        /// </summary>
        public string IbgeTownCode { get; set; }
    }
}
