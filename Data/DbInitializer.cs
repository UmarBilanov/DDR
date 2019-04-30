using DiamondDrillingReport.Models;
using System.Linq;

namespace DiamondDrillingReport.Data
{
    public class DbInitializer
    {
        public static void Initialize(DiamondDrillingReportContext context)
        {
            context.Database.EnsureCreated();

            if (context.Drill.Any())
            {
                return;   // DB has been seeded
            }

            var drills = new Drill[]
                {
            new Drill{DrillCode="YELLOW #1113", DrillNum="1113", DrillColour="YELLOW", Modification="LY50", DrillName="1113 LY50 YELLOW", Depth=500},
            new Drill{DrillCode="ORANGE #1115", DrillNum="1115", DrillColour="ORANGE", Modification="LY50", DrillName="1115 LY50 ORANGE", Depth=900},
            new Drill{DrillCode="RED #1116", DrillNum="1116", DrillColour="RED", Modification="LF140", DrillName="1116 LF140 RED", Depth=1000},
            new Drill{DrillCode="BLUE #1117", DrillNum="1117", DrillColour="BLUE", Modification="LF140", DrillName="1117 LF140 BLUE", Depth=1000},
            new Drill{DrillCode="GREEN #1118", DrillNum="1118", DrillColour="GREEN", Modification="LF140", DrillName="1118 LF140 GREEN", Depth=1000},
            new Drill{DrillCode="BLACK #1119", DrillNum="1119", DrillColour="BLACK", Modification="LY50", DrillName="1119 LY50 BLACK", Depth=900},
            new Drill{DrillCode="LM90 #1181", DrillNum="1181", DrillColour="PALE", Modification="LM90", DrillName="1181 LM90 PALE", Depth=600},
            new Drill{DrillCode="YDX1800", DrillNum="YDX1800", DrillColour="", Modification="YDX1800", DrillName="YDX1800", Depth=560},
            new Drill{DrillCode="HYDX5A", DrillNum="HYDX5A", DrillColour="", Modification="HYDX5A", DrillName="HYDX5A", Depth=200},
            new Drill{DrillCode="HYDX6", DrillNum="HYDX6", DrillColour="", Modification="HYDX6", DrillName="HYDX6", Depth=500},
            new Drill{DrillCode="HYDX44LT", DrillNum="HYDX44LT", DrillColour="", Modification="HYDX44LT", DrillName="HYDX44LT", Depth=0},
                };
            foreach (Drill s in drills)
            {
                context.Drill.Add(s);
            }

            context.SaveChanges();


        }
    }
}
