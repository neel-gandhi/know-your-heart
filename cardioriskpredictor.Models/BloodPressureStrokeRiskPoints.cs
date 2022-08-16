using System.Collections.Generic;

namespace cardioriskpredictor.Models
{
    public class BloodPressureStrokeRiskPoints
    {
        private Dictionary<List<int>, int> MaleTreatedBloodPressureStrokeRiskPoint = new Dictionary<List<int>, int>();
        private Dictionary<List<int>, int> MaleUntreatedBloodPressureStrokeRiskPoint = new Dictionary<List<int>, int>();
        private Dictionary<List<int>, int> FemaleTreatedBloodPressureStrokeRiskPoint = new Dictionary<List<int>, int>();
        private Dictionary<List<int>, int> FemaleUntreatedBloodPressureStrokeRiskPoint = new Dictionary<List<int>, int>();

        public BloodPressureStrokeRiskPoints()
        {
            DeclareMaleTreatedBloodPressureStrokeRiskPoints();
            DeclareMaleUntreatedBloodPressureStrokeRiskPoints();
            DeclareFemaleTreatedBloodPressureStrokeRiskPoints();
            DeclareFemaleUntreatedBloodPressureStrokeRiskPoints();
        }

        private void DeclareMaleTreatedBloodPressureStrokeRiskPoints()
        {
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 85, 105 }, 0);
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 106, 112 }, 1);
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 113, 117 }, 2);
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 118, 123 }, 3);
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 124, 129 }, 4);
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 130, 135 }, 5);
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 136, 142 }, 6);
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 143, 150 }, 7);
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 151, 161 }, 8);
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 162, 176 }, 9);
            MaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 177, 215 }, 10);
        }

        private void DeclareMaleUntreatedBloodPressureStrokeRiskPoints()
        {
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 85, 105 }, 0);
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 106, 115 }, 1);
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 116, 125 }, 2);
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 126, 135 }, 3);
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 136, 145 }, 4);
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 146, 155 }, 5);
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 156, 165 }, 6);
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 166, 175 }, 7);
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 176, 185 }, 8);
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 186, 195 }, 9);
            MaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 196, 215 }, 10);
        }

        private void DeclareFemaleTreatedBloodPressureStrokeRiskPoints()
        {
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 85, 94 }, 0);
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 95, 106 }, 1);
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 107, 113 }, 2);
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 114, 119 }, 3);
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 120, 125 }, 4);
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 126, 131 }, 5);
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 132, 139 }, 6);
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 140, 148 }, 7);
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 149, 160 }, 8);
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 161, 204 }, 9);
            FemaleTreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 205, 215 }, 10);
        }

        private void DeclareFemaleUntreatedBloodPressureStrokeRiskPoints()
        {
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 85, 94 }, 0);
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 95, 106 }, 1);
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 107, 118 }, 2);
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 119, 130 }, 3);
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 131, 143 }, 4);
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 144, 155 }, 5);
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 156, 167 }, 6);
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 168, 180 }, 7);
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 181, 192 }, 8);
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 193, 204 }, 9);
            FemaleUntreatedBloodPressureStrokeRiskPoint.Add(new List<int> { 205, 215 }, 10);
        }

        public int GetBloodPressureStrokeRiskPoints(int bp, bool treated, GenderEnum gender)
        {
            if (treated)
            {
                if (gender == GenderEnum.Male)
                {
                    return GetRiskPoints(MaleTreatedBloodPressureStrokeRiskPoint, bp);
                }
                else
                {
                    return GetRiskPoints(FemaleTreatedBloodPressureStrokeRiskPoint, bp);
                }
            }
            else
            {
                if (gender == GenderEnum.Male)
                {
                    return GetRiskPoints(MaleUntreatedBloodPressureStrokeRiskPoint, bp);
                }
                else
                {
                    return GetRiskPoints(FemaleUntreatedBloodPressureStrokeRiskPoint, bp);
                }
            }
        }

        private int GetRiskPoints(Dictionary<List<int>, int> PointsRange, int bp)
        {
            foreach(var range in PointsRange.Keys)
            {
                if (bp >= range[0] && bp <= range[1])
                {
                    return PointsRange[range];
                }
            }
            return 0;
        }
    }
}
