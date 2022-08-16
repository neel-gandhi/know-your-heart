using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cardioriskpredictor.Models;

namespace cardioriskpredictor.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public HealthData HealthData { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }
        public string[] Genders = new[] { GenderEnum.Male.ToString(), GenderEnum.Female.ToString() };

        [BindProperty]
        [Required(ErrorMessage = "Smoker selection is required.")]
        public string Smoker { get; set; }
        public string[] SmokerOptions = new[] { "Yes", "No" };

        [BindProperty]
        [Required(ErrorMessage = "Hypertension Treatment selection is required.")]
        public string BloodPressureTreated { get; set; }
        public string[] BloodPressureTreatedOptions = new[] { "Yes", "No" };

        public string RiskPercentage { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                var SelectedGender = Gender == GenderEnum.Male.ToString() ? GenderEnum.Male : GenderEnum.Female;
                var IsBloodPressureTreated = BloodPressureTreated == "Yes";
                var IsSmoker = Smoker == "Yes";

                var AgeRiskPoints = new AgeRiskPoints().GetAgeRiskPoints(HealthData.AgeGroup, SelectedGender);
                var CholesterolRiskPoitns = new CholesterolRiskPoints()
                    .GetCholesterolRiskPoints(HealthData.Cholesterol, SelectedGender, HealthData.AgeGroup);
                var HDLRiskPoints = new HDLRiskPoints().GetHDLRiskPoints(HealthData.HDL);
                var BloodPressureRiskPoints = new BloodPressureRiskPoints()
                    .GetBloodPressureRiskPoints(HealthData.BloodPressure, IsBloodPressureTreated, SelectedGender);
                var SmokingRiskPoints = IsSmoker ? new SmokingRiskPoints().GetSmokingRiskPoints(HealthData.AgeGroup, SelectedGender) : 0;

                var TotalRiskPoints = AgeRiskPoints + CholesterolRiskPoitns
                    + HDLRiskPoints + BloodPressureRiskPoints + SmokingRiskPoints;

                RiskPercentage = "Your risk of coronary heart disease (CHD) for next 10 years is: "
                    + OverallRiskPercentage.getRiskPercentage(TotalRiskPoints, SelectedGender);
            }
        }
    }
}
