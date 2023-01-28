using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Standard
    {
        /// <summary>
        /// Dia da semana.
        /// </summary>
        public EnumWeekDay weekday { get; set; }

        /// <summary>
        /// Horário padrão de início de atendimento.
        /// </summary>
        public string OpeningTime { get; set; }

        /// <summary>
        /// Horário padrão de encerramento de atendimento.
        /// </summary>
        public string ClosingTime { get; set; }
    }
}
