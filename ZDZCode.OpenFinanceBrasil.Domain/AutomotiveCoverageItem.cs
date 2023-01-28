using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AutomotiveCoverageItem
    {
        /// <summary>
        /// É o conjunto dos riscos cobertos elencados na apólice. (RESOLUÇÃO CNSP Nº 341/2016). Listagem de coberturas incluídas no produto que deve observar a relação discriminada de coberturas, conforme Tabela Tipo de Cobertura
        /// </summary>
        [Required]
        public EnumAutomotiveCoverageType Type { get; set; }

        /// <summary>
        /// Campo aberto para detalhamento de cada uma das coberturas possíveis dos produtos a ser feito por cada participante, conforme domínios da lista padronizada de coberturas (macro).
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Indicação se a cobertura permite contratação separada (por cobertura selecionada) conforme domínios abaixo:
        /// 1. true
        /// 2. false
        /// </summary>
        public bool PermissionSeparateAcquisition { get; set; }

        /// <summary>
        /// Atributos da cobertura
        /// </summary>
        [Required]
        public AutomotiveCoverageItemAttributes Attributes { get; set; }
    }
}
