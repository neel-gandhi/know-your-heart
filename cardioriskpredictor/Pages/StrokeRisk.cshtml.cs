using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using cardioriskpredictor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cardioriskpredictor.Pages
{
    public class StrokeRiskModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Age is required.")]
        public string Age { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Systolic Blood Pressure is required.")]
        public string BloodPressure { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }
        public string[] Genders = new[] { GenderEnum.Male.ToString(), GenderEnum.Female.ToString() };

        [BindProperty]
        [Required(ErrorMessage = "Smoker selection is required.")]
        public string Smoker { get; set; }
        public string[] SmokerOptions = new[] { "Yes", "No" };

        [BindProperty]
        [Required(ErrorMessage = "Diabetes selection is required.")]
        public string Diabetes { get; set; }
        public string[] DiabetesOptions = new[] { "Yes", "No" };

        [BindProperty]
        [Required(ErrorMessage = "Hypertension Treatment selection is required.")]
        public string BloodPressureTreated { get; set; }
        public string[] BloodPressureTreatedOptions = new[] { "Yes", "No" };

        [BindProperty]
        [Required(ErrorMessage = "CD History is required.")]
        public string CardioVascularHistory { get; set; }
        public string[] CardioVascularHistoryOptions = new[] { "Yes", "No" };

        [BindProperty]
        [Required(ErrorMessage = "Atrial Fibrillation History is required.")]
        public string AtrialFibrillationHistory { get; set; }
        public string[] AtrialFibrillationHistoryOptions = new[] { "Yes", "No" };

        [BindProperty]
        [Required(ErrorMessage = "LVH History is required.")]
        public string LeftVentricularHypertrophyHistory { get; set; }
        public string[] LeftVentricularHypertrophyHistoryOptions = new[] { "Yes", "No" };

        public string RiskPercentage { get; set; }


        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                var SelectedGender = Gender == GenderEnum.Male.ToString() ? GenderEnum.Male : GenderEnum.Female;
                var age = Int32.Parse(Age);
                var bp = Int32.Parse(BloodPressure);
                var BpTreated = BloodPressureTreated == "Yes";
                var smoker = Smoker == "Yes";
                var diabetes = Diabetes == "Yes";
                var cvh = CardioVascularHistory == "Yes";
                var afh = AtrialFibrillationHistory == "Yes";
                var lvh = LeftVentricularHypertrophyHistory == "Yes";

                var AgeRiskPoints = new AgeStrokeRiskPoints().GetAgeStrokeRiskPoints(age, SelectedGender);
                var BpRiskPoints = new BloodPressureStrokeRiskPoints().GetBloodPressureStrokeRiskPoints(bp, BpTreated, SelectedGender);
                var DiabetesRiskPoints = this.DiabetesRiskPoints(SelectedGender, diabetes);
                var SmokingRiskPoints = smoker ? 3 : 0;
                var CvhRiskPoints = this.CvhRiskPoints(SelectedGender, cvh);
                var AfhRiskPoints = this.AfhRiskPoints(SelectedGender, afh);
                var LvhRiskPoints = lvh ? 5 : 0;

                var TotalRiskPoints = AgeRiskPoints + BpRiskPoints
                    + DiabetesRiskPoints + SmokingRiskPoints + CvhRiskPoints
                    + AfhRiskPoints + LvhRiskPoints;

                RiskPercentage = "Your risk of heart stroke for next 10 years is: "
                    + OverallStrokeRiskPercentage.getRiskPercentage(TotalRiskPoints, SelectedGender) + "%";
            }
        }

        private int DiabetesRiskPoints(GenderEnum gender, bool diabetes)
        {
            if (gender == GenderEnum.Male)
            {
                return diabetes ? 2 : 0;
            }
            else
            {
                return diabetes ? 3 : 0;
            }
        }

        private int CvhRiskPoints(GenderEnum gender, bool cvh)
        {
            if (gender == GenderEnum.Male)
            {
                return cvh ? 4 : 0;
            }
            else
            {
                return cvh ? 2 : 0;
            }
        }

        private int AfhRiskPoints(GenderEnum gender, bool afh)
        {
            if (gender == GenderEnum.Male)
            {
                return afh ? 4 : 0;
            }
            else
            {
                return afh ? 6 : 0;
            }
        }
    }
}
