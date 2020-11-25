using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Zespolowy.Models
{
    public class Car
    {
        public int idCar { get; set; }

        public string ownerName { get; set; }

        public string ownerAddress { get; set; }

        public DateTime registrationDate { get; set; }

        public string numerPlate { get; set; }

        public int mileage { get; set; }
    }
}
