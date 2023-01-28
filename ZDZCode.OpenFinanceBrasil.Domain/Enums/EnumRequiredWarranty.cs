using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumRequiredWarranty
    {
        /// <summary>
        /// Cessão de direitos creditórios
        /// </summary>
        [Description("Cessão de direitos creditórios")]
        CESSAO_DIREITOS_CREDITORIOS = 1,

        /// <summary>
        /// Caução
        /// </summary>
        [Description("Caução")]
        ACAUCAO = 2,

        /// <summary>
        /// Penhor
        /// </summary>
        [Description("Penhor")]
        PENHOR = 3,

        /// <summary>
        /// Alienação fiduciária
        /// </summary>
        [Description("Alienação fiduciária")]
        ALIENACAO_FIDUCIARIA = 4,

        /// <summary>
        /// Hipoteca
        /// </summary>
        [Description("Hipoteca")]
        HIPOTECA = 5,

        /// <summary>
        /// Operações garantidas pelo governo
        /// </summary>
        [Description("Operações garantidas pelo governo")]
        OPERACOES_GARANTIDAS_PELO_GOVERNO = 6,

        /// <summary>
        /// Outras garantias não fidejussórias
        /// </summary>
        [Description("Outras garantias não fidejussórias")]
        OUTRAS_GARANTIAS_NAO_FIDEJUSSORIAS = 7,

        /// <summary>
        /// OUTRAS_GARANTIAS_NAO_FIDEJUSSORIAS	
        /// </summary>
        [Description("OUTRAS_GARANTIAS_NAO_FIDEJUSSORIAS")]
        SEGUROS_ASSEMELHADOS = 8,

        /// <summary>
        /// Garantia fidejussória
        /// </summary>
        [Description("Garantia fidejussória")]
        GARANTIA_FIDEJUSSORIA = 9,

        /// <summary>
        /// Bens arrendados
        /// </summary>
        [Description("Bens arrendados")]
        BENS_ARRENDADOS = 10,

        /// <summary>
        /// Garantias internacionais
        /// </summary>
        [Description("Garantias internacionais")]
        GARANTIAS_INTERNACIONAIS = 11,

        /// <summary>
        /// Operações garantidas por outras entidades
        /// </summary>
        [Description("Operações garantidas por outras entidades")]
        OPERACOES_GARANTIDAS_OUTRAS_ENTIDADES = 12,

        /// <summary>
        /// Acordos de compensação
        /// </summary>
        [Description("Acordos de compensação")]
        ACORDOS_COMPENSACAO = 13,

        /// <summary>
        /// Não aplicável
        /// </summary>
        [Description("Não aplicável")]
        NAO_APLICAVEL = 14,



    }
}
