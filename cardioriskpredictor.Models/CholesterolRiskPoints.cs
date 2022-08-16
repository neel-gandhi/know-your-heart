using System;
using System.Collections.Generic;

namespace cardioriskpredictor.Models
{
    public class CholesterolRiskPoints
    {
        public Dictionary<Cholesterol, Dictionary<AgeGroup, int>> MaleCholesterolRiskPoint =
            new Dictionary<Cholesterol, Dictionary<AgeGroup, int>>();

        public Dictionary<Cholesterol, Dictionary<AgeGroup, int>> FemaleCholesterolRiskPoint =
            new Dictionary<Cholesterol, Dictionary<AgeGroup, int>>();

        public CholesterolRiskPoints()
        {
            DeclarMaleCholesterolRiskPoints();
            DeclarFemaleCholesterolRiskPoints();
        }

        public void DeclarMaleCholesterolRiskPoints()
        {
            MaleCholesterolRiskPoint.Add(Cholesterol.OneSixtyOrLess, MaleCholAgeRisk160OrLess());
            MaleCholesterolRiskPoint.Add(Cholesterol.OneSixtyToOneNintyNine, MaleCholAgeRisk160To199());
            MaleCholesterolRiskPoint.Add(Cholesterol.TwoHundredToTwoThirtyNine, MaleCholAgeRisk200To239());
            MaleCholesterolRiskPoint.Add(Cholesterol.TwoFourtyToTwoSeventyNine, MaleCholAgeRisk240To279());
            MaleCholesterolRiskPoint.Add(Cholesterol.TwoEightyPlus, MaleCholAgeRisk280Above());
        }

        public void DeclarFemaleCholesterolRiskPoints()
        {
            FemaleCholesterolRiskPoint.Add(Cholesterol.OneSixtyOrLess, FemaleCholAgeRisk160OrLess());
            FemaleCholesterolRiskPoint.Add(Cholesterol.OneSixtyToOneNintyNine, FemaleCholAgeRisk160To199());
            FemaleCholesterolRiskPoint.Add(Cholesterol.TwoHundredToTwoThirtyNine, FemaleCholAgeRisk200To239());
            FemaleCholesterolRiskPoint.Add(Cholesterol.TwoFourtyToTwoSeventyNine, FemaleCholAgeRisk240To279());
            FemaleCholesterolRiskPoint.Add(Cholesterol.TwoEightyPlus, FemaleCholAgeRisk280Above());
        }

        private Dictionary<AgeGroup, int> MaleCholAgeRisk160OrLess()
        {
            return new Dictionary<AgeGroup, int>
            {
                { AgeGroup.TwentyToThirtyFour, 0 },
                { AgeGroup.ThirtyFiveToThirtyNine, 0 },
                { AgeGroup.FourtyToFourtyFour, 0 },
                { AgeGroup.FourtyFiveToFourtyNine, 0 },
                { AgeGroup.FiftyToFiftyFour, 0 },
                { AgeGroup.FiftyFiveToFiftyNine, 0 },
                { AgeGroup.SixtyToSixtyFour, 0 },
                { AgeGroup.SixtyFiveToSixtyNine, 0 },
                { AgeGroup.SeventyToSeventyFour, 0 },
                { AgeGroup.SeventyFiveAndAbove, 0 }
            };
        }

        private Dictionary<AgeGroup, int> MaleCholAgeRisk160To199()
        {
            return new Dictionary<AgeGroup, int>
            {
                { AgeGroup.TwentyToThirtyFour, 4 },
                { AgeGroup.ThirtyFiveToThirtyNine, 4 },
                { AgeGroup.FourtyToFourtyFour, 3 },
                { AgeGroup.FourtyFiveToFourtyNine, 3 },
                { AgeGroup.FiftyToFiftyFour, 2 },
                { AgeGroup.FiftyFiveToFiftyNine, 2 },
                { AgeGroup.SixtyToSixtyFour, 1 },
                { AgeGroup.SixtyFiveToSixtyNine, 1 },
                { AgeGroup.SeventyToSeventyFour, 0 },
                { AgeGroup.SeventyFiveAndAbove, 0 }
            };
        }

        private Dictionary<AgeGroup, int> MaleCholAgeRisk200To239()
        {
            return new Dictionary<AgeGroup, int>
            {
                { AgeGroup.TwentyToThirtyFour, 7 },
                { AgeGroup.ThirtyFiveToThirtyNine, 7 },
                { AgeGroup.FourtyToFourtyFour, 5 },
                { AgeGroup.FourtyFiveToFourtyNine, 5 },
                { AgeGroup.FiftyToFiftyFour, 3 },
                { AgeGroup.FiftyFiveToFiftyNine, 3 },
                { AgeGroup.SixtyToSixtyFour, 1 },
                { AgeGroup.SixtyFiveToSixtyNine, 1 },
                { AgeGroup.SeventyToSeventyFour, 0 },
                { AgeGroup.SeventyFiveAndAbove, 0 }
            };
        }

        private Dictionary<AgeGroup, int> MaleCholAgeRisk240To279()
        {
            return new Dictionary<AgeGroup, int>
            {
                { AgeGroup.TwentyToThirtyFour, 9 },
                { AgeGroup.ThirtyFiveToThirtyNine, 9 },
                { AgeGroup.FourtyToFourtyFour, 6 },
                { AgeGroup.FourtyFiveToFourtyNine, 6 },
                { AgeGroup.FiftyToFiftyFour, 4 },
                { AgeGroup.FiftyFiveToFiftyNine, 4 },
                { AgeGroup.SixtyToSixtyFour, 2 },
                { AgeGroup.SixtyFiveToSixtyNine, 2 },
                { AgeGroup.SeventyToSeventyFour, 1 },
                { AgeGroup.SeventyFiveAndAbove, 1 }
            };
        }

        private Dictionary<AgeGroup, int> MaleCholAgeRisk280Above()
        {
            return new Dictionary<AgeGroup, int>
            {
                { AgeGroup.TwentyToThirtyFour, 11 },
                { AgeGroup.ThirtyFiveToThirtyNine, 11 },
                { AgeGroup.FourtyToFourtyFour, 8 },
                { AgeGroup.FourtyFiveToFourtyNine, 8 },
                { AgeGroup.FiftyToFiftyFour, 5 },
                { AgeGroup.FiftyFiveToFiftyNine, 5 },
                { AgeGroup.SixtyToSixtyFour, 3 },
                { AgeGroup.SixtyFiveToSixtyNine, 3 },
                { AgeGroup.SeventyToSeventyFour, 1 },
                { AgeGroup.SeventyFiveAndAbove, 1 }
            };
        }

        private Dictionary<AgeGroup, int> FemaleCholAgeRisk160OrLess()
        {
            return new Dictionary<AgeGroup, int>
            {
                { AgeGroup.TwentyToThirtyFour, 0 },
                { AgeGroup.ThirtyFiveToThirtyNine, 0 },
                { AgeGroup.FourtyToFourtyFour, 0 },
                { AgeGroup.FourtyFiveToFourtyNine, 0 },
                { AgeGroup.FiftyToFiftyFour, 0 },
                { AgeGroup.FiftyFiveToFiftyNine, 0 },
                { AgeGroup.SixtyToSixtyFour, 0 },
                { AgeGroup.SixtyFiveToSixtyNine, 0 },
                { AgeGroup.SeventyToSeventyFour, 0 },
                { AgeGroup.SeventyFiveAndAbove, 0 }
            };
        }

        private Dictionary<AgeGroup, int> FemaleCholAgeRisk160To199()
        {
            return new Dictionary<AgeGroup, int>
            {
                { AgeGroup.TwentyToThirtyFour, 4 },
                { AgeGroup.ThirtyFiveToThirtyNine, 4 },
                { AgeGroup.FourtyToFourtyFour, 3 },
                { AgeGroup.FourtyFiveToFourtyNine, 3 },
                { AgeGroup.FiftyToFiftyFour, 2 },
                { AgeGroup.FiftyFiveToFiftyNine, 2 },
                { AgeGroup.SixtyToSixtyFour, 1 },
                { AgeGroup.SixtyFiveToSixtyNine, 1 },
                { AgeGroup.SeventyToSeventyFour, 1 },
                { AgeGroup.SeventyFiveAndAbove, 1 }
            };
        }

        private Dictionary<AgeGroup, int> FemaleCholAgeRisk200To239()
        {
            return new Dictionary<AgeGroup, int>
            {
                { AgeGroup.TwentyToThirtyFour, 8 },
                { AgeGroup.ThirtyFiveToThirtyNine, 8 },
                { AgeGroup.FourtyToFourtyFour, 6 },
                { AgeGroup.FourtyFiveToFourtyNine, 6 },
                { AgeGroup.FiftyToFiftyFour, 4 },
                { AgeGroup.FiftyFiveToFiftyNine, 4 },
                { AgeGroup.SixtyToSixtyFour, 2 },
                { AgeGroup.SixtyFiveToSixtyNine, 2 },
                { AgeGroup.SeventyToSeventyFour, 1 },
                { AgeGroup.SeventyFiveAndAbove, 1 }
            };
        }

        private Dictionary<AgeGroup, int> FemaleCholAgeRisk240To279()
        {
            return new Dictionary<AgeGroup, int>
            {
                { AgeGroup.TwentyToThirtyFour, 11 },
                { AgeGroup.ThirtyFiveToThirtyNine, 11 },
                { AgeGroup.FourtyToFourtyFour, 8 },
                { AgeGroup.FourtyFiveToFourtyNine, 8 },
                { AgeGroup.FiftyToFiftyFour, 5 },
                { AgeGroup.FiftyFiveToFiftyNine, 5 },
                { AgeGroup.SixtyToSixtyFour, 3 },
                { AgeGroup.SixtyFiveToSixtyNine, 3 },
                { AgeGroup.SeventyToSeventyFour, 2 },
                { AgeGroup.SeventyFiveAndAbove, 2 }
            };
        }

        private Dictionary<AgeGroup, int> FemaleCholAgeRisk280Above()
        {
            return new Dictionary<AgeGroup, int>
            {
                { AgeGroup.TwentyToThirtyFour, 13 },
                { AgeGroup.ThirtyFiveToThirtyNine, 13 },
                { AgeGroup.FourtyToFourtyFour, 10 },
                { AgeGroup.FourtyFiveToFourtyNine, 10 },
                { AgeGroup.FiftyToFiftyFour, 7 },
                { AgeGroup.FiftyFiveToFiftyNine, 7 },
                { AgeGroup.SixtyToSixtyFour, 4 },
                { AgeGroup.SixtyFiveToSixtyNine, 4 },
                { AgeGroup.SeventyToSeventyFour, 2 },
                { AgeGroup.SeventyFiveAndAbove, 2 }
            };
        }

        public int GetCholesterolRiskPoints(Cholesterol Cholesterol, GenderEnum Gender, AgeGroup AgeGroup)
        {
            if (Gender == GenderEnum.Male)
            {
                return MaleCholesterolRiskPoint[Cholesterol][AgeGroup];
            }
            else
            {
                return FemaleCholesterolRiskPoint[Cholesterol][AgeGroup];
            }
        }
    }
}
