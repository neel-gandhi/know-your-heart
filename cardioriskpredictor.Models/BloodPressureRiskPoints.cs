using System.Collections.Generic;

namespace cardioriskpredictor.Models
{
    public class BloodPressureRiskPoints
    {
        public Dictionary<BloodPressure, int> MaleTreatedBloodPressureRiskPoint = new Dictionary<BloodPressure, int>();
        public Dictionary<BloodPressure, int> MaleUntreatedBloodPressureRiskPoint = new Dictionary<BloodPressure, int>();
        public Dictionary<BloodPressure, int> FemaleTreatedBloodPressureRiskPoint = new Dictionary<BloodPressure, int>();
        public Dictionary<BloodPressure, int> FemaleUntreatedBloodPressureRiskPoint = new Dictionary<BloodPressure, int>();

        public BloodPressureRiskPoints()
        {
            DeclareMaleTreatedBloodPressureRiskPoints();
            DeclareMaleUntreatedBloodPressureRiskPoints();
            DeclareFemaleTreatedBloodPressureRiskPoints();
            DeclareFemaleUntreatedBloodPressureRiskPoints();
        }

        public void DeclareMaleTreatedBloodPressureRiskPoints()
        {
            MaleTreatedBloodPressureRiskPoint.Add(BloodPressure.BelowOneTwenty, 0);
            MaleTreatedBloodPressureRiskPoint.Add(BloodPressure.OneTwentyToOneTwentyNine, 1);
            MaleTreatedBloodPressureRiskPoint.Add(BloodPressure.OneThirtyToOneThirtyNine, 2);
            MaleTreatedBloodPressureRiskPoint.Add(BloodPressure.OneFourtyToOneFiftyNine, 2);
            MaleTreatedBloodPressureRiskPoint.Add(BloodPressure.OneSixtyPlus, 3);
        }

        public void DeclareMaleUntreatedBloodPressureRiskPoints()
        {
            MaleUntreatedBloodPressureRiskPoint.Add(BloodPressure.BelowOneTwenty, 0);
            MaleUntreatedBloodPressureRiskPoint.Add(BloodPressure.OneTwentyToOneTwentyNine, 0);
            MaleUntreatedBloodPressureRiskPoint.Add(BloodPressure.OneThirtyToOneThirtyNine, 1);
            MaleUntreatedBloodPressureRiskPoint.Add(BloodPressure.OneFourtyToOneFiftyNine, 1);
            MaleUntreatedBloodPressureRiskPoint.Add(BloodPressure.OneSixtyPlus, 2);
        }

        public void DeclareFemaleTreatedBloodPressureRiskPoints()
        {
            FemaleTreatedBloodPressureRiskPoint.Add(BloodPressure.BelowOneTwenty, 0);
            FemaleTreatedBloodPressureRiskPoint.Add(BloodPressure.OneTwentyToOneTwentyNine, 3);
            FemaleTreatedBloodPressureRiskPoint.Add(BloodPressure.OneThirtyToOneThirtyNine, 4);
            FemaleTreatedBloodPressureRiskPoint.Add(BloodPressure.OneFourtyToOneFiftyNine, 5);
            FemaleTreatedBloodPressureRiskPoint.Add(BloodPressure.OneSixtyPlus, 6);
        }

        public void DeclareFemaleUntreatedBloodPressureRiskPoints()
        {
            FemaleUntreatedBloodPressureRiskPoint.Add(BloodPressure.BelowOneTwenty, 0);
            FemaleUntreatedBloodPressureRiskPoint.Add(BloodPressure.OneTwentyToOneTwentyNine, 1);
            FemaleUntreatedBloodPressureRiskPoint.Add(BloodPressure.OneThirtyToOneThirtyNine, 2);
            FemaleUntreatedBloodPressureRiskPoint.Add(BloodPressure.OneFourtyToOneFiftyNine, 3);
            FemaleUntreatedBloodPressureRiskPoint.Add(BloodPressure.OneSixtyPlus, 4);
        }

        public int GetBloodPressureRiskPoints(BloodPressure BloodPressure, bool treated, GenderEnum gender)
        {
            if (treated)
            {
                if (gender == GenderEnum.Male)
                {
                    return MaleTreatedBloodPressureRiskPoint[BloodPressure];
                }
                else
                {
                    return MaleTreatedBloodPressureRiskPoint[BloodPressure];
                }
            }
            else
            {
                if (gender == GenderEnum.Male)
                {
                    return MaleUntreatedBloodPressureRiskPoint[BloodPressure];
                }
                else
                {
                    return MaleUntreatedBloodPressureRiskPoint[BloodPressure];
                }
            }
        }
    }
}
