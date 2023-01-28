using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// No caso de contratação de várias coberturas numa mesma apólice, é comum o contrato estabelecer, para cada uma delas, um distinto limite máximo de responsabilidade por parte da seguradora. Cada um deles é denominado o Limite Máximo de Indenização (ou a Importância Segurada (IS), de cada cobertura contratada. Ressalte-se que estes limites são independentes, não se somando nem se comunicando. (Circular SUSEP 291/05); Lista com valor mínimo de LMI/IS aceito pela sociedade para cada cobertura. Em reais (R$) Importante: Campo de valor financeiro relacionado à cobertura que possui o campo. Quando não houver o campo, enviar o valor zerado.
    /// </summary>
    public class CoverageItemAttributesMinLMI
    {
        /// <summary>
        /// Valor mínimo de cobertura (Capital Segurado), diária ou parcela aceito pela sociedade para cada combinação de modalidade/cobertura do produto. Conforme moeda.
        /// </summary>
        [Required]
        public string Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor monetário, seguindo o modelo ISO-4217.
        /// </summary>
        [Required]
        public CurrencyCode Currency { get; set; }
    }
}
