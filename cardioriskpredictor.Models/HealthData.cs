using System.ComponentModel.DataAnnotations;

namespace cardioriskpredictor.Models
{
    public class HealthData
    {
        public AgeGroup AgeGroup { get; set; }
        public Cholesterol Cholesterol { get; set; }
        public HDL HDL { get; set; }
        public BloodPressure BloodPressure { get; set; }

        public HealthData() {}
    }
}
