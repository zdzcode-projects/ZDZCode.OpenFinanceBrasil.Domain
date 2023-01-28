using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class NewCar
    {
        /// <summary>
        /// Base de contratação
        /// </summary>
        public ContractBase ContractBase { get; set; }

        /// <summary>
        /// Prazo máximo para veículo zero quilômetro em meses
        /// </summary>
        public int MaximumCalculatingPeriod { get; set; }
    }
}
