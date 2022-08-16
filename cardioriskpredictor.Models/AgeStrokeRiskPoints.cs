using System.Collections.Generic;

namespace cardioriskpredictor.Models
{
    public class AgeStrokeRiskPoints
    {
        private Dictionary<List<int>, int> MaleAgeStrokeRiskPoint = new Dictionary<List<int>, int>();
        private Dictionary<List<int>, int> FemaleAgeStrokeRiskPoint = new Dictionary<List<int>, int>();

        public AgeStrokeRiskPoints()
        {
            DeclareMaleAgeStrokeRiskPoints();
            DeclareFemaleAgeStrokeRiskPoints();
        }

        private void DeclareMaleAgeStrokeRiskPoints()
        {
            MaleAgeStrokeRiskPoint.Add(new List<int> { 50, 56 }, 0);
            MaleAgeStrokeRiskPoint.Add(new List<int> { 57, 59 }, 1);
            MaleAgeStrokeRiskPoint.Add(new List<int> { 60, 62 }, 2);
            MaleAgeStrokeRiskPoint.Add(new List<int> { 63, 65 }, 3);
            MaleAgeStrokeRiskPoint.Add(new List<int> { 66, 68 }, 4);
            MaleAgeStrokeRiskPoint.Add(new List<int> { 69, 72 }, 5);
            MaleAgeStrokeRiskPoint.Add(new List<int> { 73, 75 }, 6);
            MaleAgeStrokeRiskPoint.Add(new List<int> { 76, 78 }, 7);
            MaleAgeStrokeRiskPoint.Add(new List<int> { 79, 81 }, 8);
            MaleAgeStrokeRiskPoint.Add(new List<int> { 82, 84 }, 9);
            MaleAgeStrokeRiskPoint.Add(new List<int> { 85, 90 }, 10);
        }

        private void DeclareFemaleAgeStrokeRiskPoints()
        {
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 50, 56 }, 0);
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 57, 59 }, 1);
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 60, 62 }, 2);
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 63, 64 }, 3);
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 65, 67 }, 4);
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 68, 70 }, 5);
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 71, 73 }, 6);
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 74, 76 }, 7);
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 77, 78 }, 8);
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 79, 81 }, 9);
            FemaleAgeStrokeRiskPoint.Add(new List<int> { 82, 90 }, 10);
        }

        public int GetAgeStrokeRiskPoints(int age, GenderEnum gender)
        {
            if (gender == GenderEnum.Male)
            {
                return GetRiskPoints(MaleAgeStrokeRiskPoint, age);
            }
            else
            {
                return GetRiskPoints(FemaleAgeStrokeRiskPoint, age);
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
