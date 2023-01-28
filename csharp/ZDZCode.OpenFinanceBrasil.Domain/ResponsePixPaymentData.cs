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
    public class ResponsePixPaymentData
    {
        /// <summary>   
        /// 	Código ou identificador único informado pela instituição detentora da conta para representar a iniciação de pagamento individual.O paymentId deve ser diferente do endToEndId. Este é o identificador que deverá ser utilizado na consulta ao status da iniciação de pagamento efetuada.
        /// </summary>
        [Required]
        public string PaymentId { get; set; }

        /// <summary>
        ///Deve ser preenchido no formato padrão ExxxxxxxxyyyyMMddHHmmkkkkkkkkkkk (32 caracteres; “case sensitive”, isso é, diferencia letras maiúsculas e minúsculas), sendo:
        /// • “E” – fixo(1 caractere);
        /// • xxxxxxxx – identificação do agente que gerou o ´EndToEndId´, podendo ser: o ISPB do participante direto ou o ISPB do participante indireto(8 caracteres numéricos [0-9]);
        /// • yyyyMMddHHmm – data, hora e minuto(12 caracteres), seguindo o horário UTC, da submissão da ordem de pagamento, caso a liquidação seja prioritária, ou prevista para o envio da ordem ao sistema de liquidação, caso seja realizado um agendamento.Para ordens prioritárias e não prioritárias, aceita-se o preenchimento, pelo agente que gerou o ´EndToEndId´, com uma tolerância máxima de 12 horas, para o futuro e para o passado, em relação ao horário efetivo de processamento da ordem pelo SPI;
        /// • kkkkkkkkkkk – sequencial criado pelo agente que gerou o ´EndToEndId´ (11 caracteres alfanuméricos[a - z / A - Z / 0 - 9]). Deve ser único dentro de cada “yyyyMMddHHmm”.
        /// Admite-se que o ´EndToEndId´ seja gerado pelo participante direto, pelo participante indireto ou pelo iniciador de pagamento.
        /// Ele deve ser único, não podendo ser repetido em qualquer outra operação enviada ao SPI.
        /// [Restrição] O ´EndToEndId´ deve ser informado obrigatoriamente caso o status do pagamento seja ACCEPTED_SETTLEMENT_COMPLETED.
        /// </summary>
        public EndToEndId EndToEndId { get; set; }

        /// <summary>
        /// Identificador único do consentimento criado para a iniciação de pagamento solicitada. Deverá ser um URN - Uniform Resource Name. Um URN, conforme definido na RFC8141 é um Uniform Resource Identifier - URI - que é atribuído sob o URI scheme "urn" e um namespace URN específico, com a intenção de que o URN seja um identificador de recurso persistente e independente da localização.
        /// Considerando a string urn:bancoex:C1DD33123 como exemplo para consentId temos:
        /// - o namespace(urn)
        /// - o identificador associado ao namespace da instituição transnmissora(bancoex)
        /// - o identificador específico dentro do namespace (C1DD33123).
        /// Informações mais detalhadas sobre a construção de namespaces devem ser consultadas na RFC8141.
        /// </summary>
        [Required]
        public string ConsentId { get; set; }

        /// <summary>
        /// Data e hora em que o recurso foi criado. Uma string com data e hora conforme especificação RFC-3339, sempre com a utilização de timezone UTC(UTC time format).
        /// </summary>
        [Required]
        public DateTime CreationDateTime { get; set; }

        /// <summary>
        /// Data e hora da última atualização da iniciação de pagamento. Uma string com data e hora conforme especificação RFC-3339, sempre com a utilização de timezone UTC(UTC time format).
        /// </summary>
        [Required]
        public DateTime StatusUpdateDateTime { get; set; }

        /// <summary>
        /// Chave cadastrada no DICT pertencente ao recebedor. Os tipos de chaves podem ser: telefone, e-mail, cpf/cnpj ou chave aleatória. No caso de telefone celular deve ser informado no padrão E.1641. Para e-mail deve ter o formato xxxxxxxx@xxxxxxx.xxx(.xx) e no máximo 77 caracteres. No caso de CPF deverá ser informado com 11 números, sem pontos ou traços.
        /// Para o caso de CNPJ deverá ser informado com 14 números, sem pontos ou traços.
        /// No caso de chave aleatória deve ser informado o UUID gerado pelo DICT, conforme formato especificado na RFC41223. Se informado, a detentora da conta deve validar o proxy no DICT quando localInstrument for igual a DICT, QRDN ou QRES e validar o campo creditorAccount. Esta validação é opcional caso o localInstrument for igual a INIC.
        /// [Restrição] Se localInstrument for igual a MANU, o campo proxy não deve ser preenchido.Se localInstrument for igual INIC, DICT, QRDN ou QRES, o campo proxy deve ser sempre preenchido com a chave Pix.
        /// </summary>
        public string Proxy { get; set; }

        /// <summary>
        /// Traz o código da cidade segundo o IBGE (Instituto Brasileiro de Geografia e Estatística). Para o preenchimento deste campo, o Iniciador de Pagamentos deve seguir a orientação do arranjo da forma de pagamento. O preenchimento do campo tanto em pix/payments quanto /consents deve ser igual.Caso haja divergência dos valores, a instituição deve retornar HTTP 422 com o código de erro PAGAMENTO_DIVERGENTE_DO_CONSENTIMENTO. Este campo faz referência ao campo CodMun do arranjo Pix.
        /// </summary>
        public string IbgeTownCode { get; set; }

        /// <summary>
        /// Estado atual da iniciação de pagamento. O estado evolui na seguinte ordem:
        /// 1. PDNG(PENDING) - Iniciação de pagamento ou transação de pagamento está pendente.Checagens adicionais em realização.
        /// 2. SASP (SCHEDULE_ACCEPTED_SETTLEMENT_IN_PROCESS) - Indica que o processo de agendamento está em processamento.
        /// 3. SASC (SCHEDULE_ACCEPTED_SETTLEMENT_COMPLETED) - Indica que o processo de agendamento foi realizado.
        /// 4. PART (PARTIALLY ACCEPTED) - Aguardando autorização múltipla alçada.
        /// 5. ACSP (ACCEPTED_SETTLEMENT_IN_PROCESS) - Iniciação de pagamento aceita e processamento do pagamento foi iniciado.
        /// 6. ACSC (ACCEPTED_SETTLEMENT_COMPLETED_DEBITOR_ACCOUNT) - Débito realizado na conta do pagador.
        /// 7. ACCC (ACCEPTED_SETTLEMENT_COMPLETED) - Crédito realizado na instituição de destino.
        /// Em caso insucesso: RJCT(REJECTED) - Instrução de pagamento rejeitada.
        /// </summary>
        [Required]
        public EnumPaymentStatusType Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public EnumRejectionReasonType RejectionReason { get; set; }

        /// <summary>
        ///Especifica a forma de iniciação do pagamento:
        /// - MANU - Inserção manual de dados da conta transacional
        /// - DICT - Inserção manual de chave Pix
        /// - QRDN - QR code dinâmico
        /// - QRES - QR code estático
        /// - INIC - Indica que o recebedor(creditor) contratou o Iniciador de Pagamentos especificamente para realizar iniciações de pagamento em que o beneficiário é previamente conhecido.
        /// </summary>
        [Required]
        public string LocalInstrument { get; set; }

        /// <summary>
        /// CNPJ do Iniciador de Pagamento devidamente habilitado para a prestação de Serviço de Iniciação no Pix.
        /// </summary>
        [Required]
        public string CnpjInitiator { get; set; }

        /// <summary>
        /// Objeto contendo dados do pagameto como moeda e valor.
        /// </summary>
        [Required]
        public PaymentPix Payment { get; set; }

        /// <summary>
        /// Trata-se de um identificador de transação que deve ser retransmitido intacto pelo PSP do pagador ao gerar a ordem de pagamento. Essa informação permitirá ao recebedor identificar e correlacionar a transferência, quando recebida, com a apresentação das instruções ao pagador.
        ///        Os caracteres permitidos no contexto do Pix para o campo txid(EMV 62-05) são:
        ///- Letras minúsculas, de ‘a’ a ‘z’
        ///- Letras maiúsculas, de ‘A’ a ‘z’
        ///- Dígitos decimais, de ‘0’ a ‘9’
        ///[Restrição] Se localInstrument for igual a INIC, o campo transactionIdentification deve ser preenchido obrigatoriamente.
        ///Se localInstrument for igual a MANU ou DICT, o campo transactionIdentification não deve ser preenchido.
        ///A detentora de conta deve validar se a condicionalidade do campo foi atendida pela iniciadora de pagamento.
        /// </summary>
        public string TransactionIdentification { get; set; }

        /// <summary>
        ///Deve ser preenchido sempre que o usuário pagador inserir alguma informação adicional em um pagamento, a ser enviada ao recebedor.
        /// </summary>
        public string RemittanceInformation { get; set; }

        /// <summary>
        /// Objeto que contém a identificação da conta de destino do beneficiário/recebedor.
        /// </summary>
        [Required]
        public CreditorAccount CreditorAccount { get; set; }
    }
}
