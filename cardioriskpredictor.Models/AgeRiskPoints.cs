using System;
using System.Collections.Generic;

namespace cardioriskpredictor.Models
{
    public class AgeRiskPoints
    {
        public Dictionary<AgeGroup, int> MaleAgeRiskPoint = new Dictionary<AgeGroup, int>();
        public Dictionary<AgeGroup, int> FemaleAgeRiskPoint = new Dictionary<AgeGroup, int>();

        public AgeRiskPoints()
        {
            DeclarMenAgeRiskPoints();
            DeclarWomenAgeRiskPoints();
        }

        public void DeclarMenAgeRiskPoints()
        {
            MaleAgeRiskPoint.Add(AgeGroup.TwentyToThirtyFour, -9);
            MaleAgeRiskPoint.Add(AgeGroup.ThirtyFiveToThirtyNine, -3);
            MaleAgeRiskPoint.Add(AgeGroup.FourtyToFourtyFour, 0);
            MaleAgeRiskPoint.Add(AgeGroup.FourtyFiveToFourtyNine, 3);
            MaleAgeRiskPoint.Add(AgeGroup.FiftyToFiftyFour, 6);
            MaleAgeRiskPoint.Add(AgeGroup.FiftyFiveToFiftyNine, 8);
            MaleAgeRiskPoint.Add(AgeGroup.SixtyToSixtyFour, 10);
            MaleAgeRiskPoint.Add(AgeGroup.SixtyFiveToSixtyNine, 11);
            MaleAgeRiskPoint.Add(AgeGroup.SeventyToSeventyFour, 12);
            MaleAgeRiskPoint.Add(AgeGroup.SeventyFiveAndAbove, 13);
        }

        public void DeclarWomenAgeRiskPoints()
        {
            FemaleAgeRiskPoint.Add(AgeGroup.TwentyToThirtyFour, -7);
            FemaleAgeRiskPoint.Add(AgeGroup.ThirtyFiveToThirtyNine, -3);
            FemaleAgeRiskPoint.Add(AgeGroup.FourtyToFourtyFour, 0);
            FemaleAgeRiskPoint.Add(AgeGroup.FourtyFiveToFourtyNine, 3);
            FemaleAgeRiskPoint.Add(AgeGroup.FiftyToFiftyFour, 6);
            FemaleAgeRiskPoint.Add(AgeGroup.FiftyFiveToFiftyNine, 8);
            FemaleAgeRiskPoint.Add(AgeGroup.SixtyToSixtyFour, 10);
            FemaleAgeRiskPoint.Add(AgeGroup.SixtyFiveToSixtyNine, 12);
            FemaleAgeRiskPoint.Add(AgeGroup.SeventyToSeventyFour, 14);
            FemaleAgeRiskPoint.Add(AgeGroup.SeventyFiveAndAbove, 16);
        }

        public int GetAgeRiskPoints(AgeGroup AgeGroup, GenderEnum Gender)
        {
            if (Gender == GenderEnum.Male)
            {
                return MaleAgeRiskPoint[AgeGroup];
            }
            else
            {
                return FemaleAgeRiskPoint[AgeGroup];
            }
        }
    }
}
