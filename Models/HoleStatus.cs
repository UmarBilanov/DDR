using System.Collections.Generic;

namespace DiamondDrillingReport.Models
{
    public class HoleStatus
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Hole> Holes { get; set; }
    }
}
