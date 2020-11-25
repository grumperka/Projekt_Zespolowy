using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Zespolowy.Models
{
    public class CarPhoto
    {
        public int idPhoto { get; set; }

        public string pathFile { get; set; }

        public string mimeType { get; set; }

        public int idRepairFK { get; set; }
    }
}
