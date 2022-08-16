using System;
using System.Collections.Generic;

namespace cardioriskpredictor.Models
{
    public class OverallStrokeRiskPercentage
    {
        private static Dictionary<int, List<int>> RiskPercentage = new Dictionary<int, List<int>>
        {
            {1, new List<int>() {3, 1 } },
            {2, new List<int>() {3, 1 } },
            {3, new List<int>() {4, 2 } },
            {4, new List<int>() {4, 2 } },
            {5, new List<int>() {5, 2 } },
            {6, new List<int>() {5, 3 } },
            {7, new List<int>() {6, 4 } },
            {8, new List<int>() {7, 4 } },
            {9, new List<int>() {8, 5 } },
            {10, new List<int>() {10, 6 } },
            {11, new List<int>() {11, 8 } },
            {12, new List<int>() {13, 9 } },
            {13, new List<int>() {15, 11 } },
            {14, new List<int>() {17, 13 } },
            {15, new List<int>() {20, 16 } },
            {16, new List<int>() {22, 19 } },
            {17, new List<int>() {26, 23 } },
            {18, new List<int>() {29, 27 } },
            {19, new List<int>() {33, 32 } },
            {20, new List<int>() {37, 37 } },
            {21, new List<int>() {42, 43 } },
            {22, new List<int>() {47, 50 } },
            {23, new List<int>() {52, 57 } },
            {24, new List<int>() {57, 64 } },
            {25, new List<int>() {63, 71 } },
            {26, new List<int>() {68, 78 } },
            {27, new List<int>() {74, 84 } },
            {28, new List<int>() {79, 84 } },
            {29, new List<int>() {84, 84 } },
            {30, new List<int>() {89, 84 } }
        };

        public static int getRiskPercentage(int RiskScore, GenderEnum gender)
        {
            return gender == GenderEnum.Male ? RiskPercentage[RiskScore][0] : RiskPercentage[RiskScore][1];
        }
    }
}
