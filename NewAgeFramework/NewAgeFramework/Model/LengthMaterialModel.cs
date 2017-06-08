using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAgeFramework.Model
{
    public class LengthMaterialModel
    {
        public int LenghtCostID { get; set; }
        public int TypeID { get; set; }
        public string MaterialID { get; set; }
        public Nullable<decimal> NoPieces { get; set; }
        public Nullable<decimal> LengthPerPiece { get; set; }
        public Nullable<decimal> TotalLength { get; set; }
        public Nullable<decimal> TotalCostPieces { get; set; }
        public Nullable<decimal> PricePerMeter { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
