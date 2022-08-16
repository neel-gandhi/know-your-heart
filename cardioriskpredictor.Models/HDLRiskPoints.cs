using System.Collections.Generic;

namespace cardioriskpredictor.Models
{
    public class HDLRiskPoints
    {
        public Dictionary<HDL, int> HDLRiskPoint = new Dictionary<HDL, int>();

        public HDLRiskPoints()
        {
            DeclareHDLRiskPoints();
        }

        public void DeclareHDLRiskPoints()
        {
            HDLRiskPoint.Add(HDL.SixtyPlus, -1);
            HDLRiskPoint.Add(HDL.FiftyToFiftyNine, 0);
            HDLRiskPoint.Add(HDL.FourtyToFourtyNine, 1);
            HDLRiskPoint.Add(HDL.BelowFourty, 2);
        }

        public int GetHDLRiskPoints(HDL hdl)
        {
            return HDLRiskPoint[hdl];
        }
    }
}
