using System;
using System.Collections.Generic;

namespace cardioriskpredictor.Models
{
    public class OverallRiskPercentage
    {
        public static string getRiskPercentage(int RiskScore, GenderEnum gender)
        {
            if (gender == GenderEnum.Male)
            {
                return getMaleRiskPercentage(RiskScore);
            }
            else
            {
                return getFemaleRiskPercentage(RiskScore);
            }
        }

        private static string getMaleRiskPercentage(int RiskScore)
        {
            if (RiskScore < 0) { return "0%"; }
            else if (RiskScore == 0) { return "< 1%"; }
            else if (RiskScore >= 1 && RiskScore <= 4) { return "1%"; }
            else if (RiskScore >= 5 && RiskScore <= 6) { return "2%"; }
            else if (RiskScore == 7) { return "3%"; }
            else if (RiskScore == 8) { return "4%"; }
            else if (RiskScore == 9) { return "5%"; }
            else if (RiskScore == 10) { return "6%"; }
            else if (RiskScore == 11) { return "8%"; }
            else if (RiskScore == 12) { return "10%"; }
            else if (RiskScore == 13) { return "12%"; }
            else if (RiskScore == 14) { return "16%"; }
            else if (RiskScore == 15) { return "20%"; }
            else if (RiskScore == 16) { return "25%"; }
            else { return "> 30%"; }
        }

        private static string getFemaleRiskPercentage(int RiskScore)
        {
            if (RiskScore < 0) { return "0%"; }
            else if (RiskScore >= 0 && RiskScore <= 8) { return "< 1%"; }
            else if (RiskScore >= 9 && RiskScore <= 12) { return "1%"; }
            else if (RiskScore >= 13 && RiskScore <= 14) { return "2%"; }
            else if (RiskScore == 15) { return "3%"; }
            else if (RiskScore == 16) { return "4%"; }
            else if (RiskScore == 17) { return "5%"; }
            else if (RiskScore == 18) { return "6%"; }
            else if (RiskScore == 19) { return "8%"; }
            else if (RiskScore == 20) { return "11%"; }
            else if (RiskScore == 21) { return "14%"; }
            else if (RiskScore == 22) { return "17%"; }
            else if (RiskScore == 23) { return "22%"; }
            else if (RiskScore == 24) { return "27%"; }
            else { return "> 30%"; }
        }
    }
}
