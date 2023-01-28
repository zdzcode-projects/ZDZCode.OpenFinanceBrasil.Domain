using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class UnarrangedAccountOverdraftContractListData
    {
        /// <summary>
        /// Um identificador único e imutável usado para identificar o contrato de uma operação de crédito. Este identificador não tem significado para o tomador do crédito
        /// </summary>
        [Required]
        public string ContractId { get; set; }

        /// <summary>
        /// Nome da Marca reportada pelo participante do Open Banking. O conceito a que se refere a 'marca' é em essência uma promessa da empresa em fornecer uma série específica de atributos, benefícios e serviços uniformes aos clientes
        /// </summary>
        [Required]
        public string BrandName { get; set; }

        /// <summary>
        /// Número completo do CNPJ da instituição responsável pelo Cadastro - o CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara
        /// </summary>
        [Required]
        public string CompanyCnpj { get; set; }

        /// <summary>
        /// "Tipo da modalidade de crédito contratada, conforme circular 4.015 e descrição do DOC3040 do SCR). (Vide Enum) Adiantamento a depositantes, Direitos creditórios descontados Empréstimos, Financiamentos, Financiamentos rurais e Financiamentos imobiliários"
        /// </summary>
        [Required]
        public EnumUnarrangedAccountOverdraftProductType ProductType { get; set; }

        /// <summary>
        /// "Sub tipo da modalidades de crédito contratadas, conforme circular 4.015 e descrição do DOC3040 do SCR). (Vide Enum) Adiantamento a depositantes
        /// </summary>
        [Required]
        public EnumUnarrangedAccountOverdraftSubProductType ProductSubType { get; set; }

        /// <summary>
        ///  "Número padronizado do contrato - IPOC (Identificação Padronizada da Operação de Crédito). Segundo DOC 3040, composta por:
        /// - CNPJ da instituição: 8 (oito) posições iniciais;
        /// - Modalidade da operação: 4 (quatro) posições;
        /// - Tipo do cliente: 1 (uma) posição( 1 = pessoa natural - CPF, 2= pessoa jurídica – CNPJ, 3 = pessoa física no exterior, 4 = pessoa jurídica no exterior, 5 = pessoa natural sem CPF e 6 = pessoa jurídica sem CNPJ);
        /// - Código do cliente: O número de posições varia conforme o tipo do cliente:
        /// 1. Para clientes pessoa física com CPF(tipo de cliente = 1), informar as 11 (onze) posições do CPF;
        /// 2. Para clientes pessoa jurídica com CNPJ(tipo de cliente = 2), informar as 8 (oito) posições iniciais do CNPJ;
        /// 3. Para os demais clientes(tipos de cliente 3, 4, 5 e 6), informar 14 (catorze) posições com complemento de zeros à esquerda se a identificação tiver tamanho inferior;
        /// - Código do contrato: 1 (uma) até 40 (quarenta) posições, sem complemento de caracteres."   
        /// </summary>
        [Required]
        public string IpocCode { get; set; }
    }
}
