using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamolotyTI
{
    public abstract class Samolot
    {
        public string Nazwa { get; set; }
        public string Model { get; set; }
        public string PredkoscPrzelotowa { get; set; }
        public int Id { get; set; }
    }
}
