using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCoverageItem
    {
        /// <summary>
        /// É o conjunto dos riscos cobertos elencados na apólice. (RESOLUÇÃO CNSP Nº 341/2016). Listagem de coberturas incluídas no produto que deve observar a relação discriminada de coberturas, conforme Tabela Tipo de Cobertura
        /// </summary>
        [Required]
        public EnumCoverageType Type { get; set; }

        /// <summary>
        /// Lista de textos para complementar informação relativa ao campo type, quando for selecionada a opção 'OUTROS'. Restrição: Campo de preenchimento obrigatório se 'type' estiver preenchida a opção 'OUTROS'
        /// </summary>
        public List<string> TypeAdditionalInfos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public PersonalCoverageItemAttributes Attributes { get; set; }
    }
}
