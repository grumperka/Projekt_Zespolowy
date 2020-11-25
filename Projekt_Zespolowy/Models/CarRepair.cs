using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Zespolowy.Models
{
    public class CarRepair
    {
        public int idRepair { get; set; }

        public string repairDescryption { get; set; }

        public DateTime repairStartDate { get; set; }

        public DateTime repairEndDate { get; set; }

        public int manHours { get; set; }

        public float cost { get; set; }

        public int idServiceFK { get; set; }

        public int idCarFK { get; set; }

    }
}
