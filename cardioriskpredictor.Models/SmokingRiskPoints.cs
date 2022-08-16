using System.Collections.Generic;

namespace cardioriskpredictor.Models
{
    public class SmokingRiskPoints
    {
        public Dictionary<AgeGroup, int> MaleSmokingRiskPoint = new Dictionary<AgeGroup, int>();
        public Dictionary<AgeGroup, int> FemaleSmokingRiskPoint = new Dictionary<AgeGroup, int>();

        public SmokingRiskPoints()
        {
            DeclareMaleSmokingRiskPoints();
            DeclareFemaleSmokingRiskPoints();
        }

        public void DeclareMaleSmokingRiskPoints()
        {
            MaleSmokingRiskPoint.Add(AgeGroup.TwentyToThirtyFour, 8);
            MaleSmokingRiskPoint.Add(AgeGroup.ThirtyFiveToThirtyNine, 8);
            MaleSmokingRiskPoint.Add(AgeGroup.FourtyToFourtyFour, 5);
            MaleSmokingRiskPoint.Add(AgeGroup.FourtyFiveToFourtyNine, 5);
            MaleSmokingRiskPoint.Add(AgeGroup.FiftyToFiftyFour, 3);
            MaleSmokingRiskPoint.Add(AgeGroup.FiftyFiveToFiftyNine, 3);
            MaleSmokingRiskPoint.Add(AgeGroup.SixtyToSixtyFour, 1);
            MaleSmokingRiskPoint.Add(AgeGroup.SixtyFiveToSixtyNine, 1);
            MaleSmokingRiskPoint.Add(AgeGroup.SeventyToSeventyFour, 1);
            MaleSmokingRiskPoint.Add(AgeGroup.SeventyFiveAndAbove, 1);
        }

        public void DeclareFemaleSmokingRiskPoints()
        {
            FemaleSmokingRiskPoint.Add(AgeGroup.TwentyToThirtyFour, 9);
            FemaleSmokingRiskPoint.Add(AgeGroup.ThirtyFiveToThirtyNine, 9);
            FemaleSmokingRiskPoint.Add(AgeGroup.FourtyToFourtyFour, 7);
            FemaleSmokingRiskPoint.Add(AgeGroup.FourtyFiveToFourtyNine, 7);
            FemaleSmokingRiskPoint.Add(AgeGroup.FiftyToFiftyFour, 4);
            FemaleSmokingRiskPoint.Add(AgeGroup.FiftyFiveToFiftyNine, 4);
            FemaleSmokingRiskPoint.Add(AgeGroup.SixtyToSixtyFour, 2);
            FemaleSmokingRiskPoint.Add(AgeGroup.SixtyFiveToSixtyNine, 2);
            FemaleSmokingRiskPoint.Add(AgeGroup.SeventyToSeventyFour, 1);
            FemaleSmokingRiskPoint.Add(AgeGroup.SeventyFiveAndAbove, 1);
        }

        public int GetSmokingRiskPoints(AgeGroup AgeGroup, GenderEnum gender)
        {
            if (gender == GenderEnum.Male)
            {
                return MaleSmokingRiskPoint[AgeGroup];
            }
            else
            {
                return FemaleSmokingRiskPoint[AgeGroup];
            }
        }
    }
}
