using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class HomeCoverageItemAttributes
    {
        /// <summary>
        /// No caso de contratação de várias coberturas numa mesma apólice, é comum o contrato estabelecer, para cada uma delas, um distinto limite máximo de responsabilidade por parte da seguradora. Cada um deles é denominado o Limite Máximo de Indenização (ou a Importância Segurada (IS), de cada cobertura contratada. Ressalte-se que estes limites são independentes, não se somando nem se comunicando. (Circular SUSEP 291/05); Lista com valor mínimo de LMI/IS aceito pela sociedade para cada cobertura. Em reais (R$) Importante: Campo de valor financeiro relacionado à cobertura que possui o campo. Quando não houver o campo, enviar o valor zerado.
        /// </summary>
        public CoverageItemAttributesMinLMI MinLMI { get; set; }

        /// <summary>
        /// Valor máximo de LMI/IS aceito pela sociedade para cada cobertura. Em reais (R$) Importante: Campo de valor numérico relacionado à cobertura que possui o campo. Quando não houver o campo, enviar o valor zerado.
        /// </summary>
        public CoverageItemAttributesMaxLMI MaxLMI { get; set; }

        /// <summary>
        /// Quantia fixa, definida na apólice, que, em caso de sinistro, representa a parte do prejuízo apurado que poderá deixar de ser paga pela Sociedade Seguradora, dependendo das disposições do contrato. (RESOLUÇÃO CNSP Nº 341/2016). Listagem de valor mínimo da franquia (Reais) estabelecida pela sociedade para cada tipo de cobertura do produto.
        /// </summary>
        public HomeMinDeductibleAmount MinDeductibleAmount { get; set; }

        /// <summary>
        /// Participação Obrigatória é o valor ou percentual definido na apólice referente à responsabilidade do Segurado nos prejuízos indenizáveis decorrentes de sinistros cobertos. (Circular SUSEP 347/07). Listagem de percentual de franquia e/ou Percentual Participação Obrigatória do Segurado estabelecida pela sociedade para cada tipo de cobertura do produto. Observação: Sugestão de Criação do campo em substituição ao campo abaixo ‘Valor Máximo de Franquia’.
        /// </summary>
        public string InsuredMandatoryParticipationPercentage { get; set; }
    }
}
