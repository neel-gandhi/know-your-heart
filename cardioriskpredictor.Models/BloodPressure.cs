using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace cardioriskpredictor.Models
{
    public enum BloodPressure
    {
        [Display(Name = "< 120")]
        BelowOneTwenty,

        [Display(Name = "120 - 129")]
        OneTwentyToOneTwentyNine,

        [Display(Name = "130 - 139")]
        OneThirtyToOneThirtyNine,

        [Display(Name = "140 - 159")]
        OneFourtyToOneFiftyNine,

        [Display(Name = "160 +")]
        OneSixtyPlus
    }

    public class BloodPressureExtension
    {
        public static string GetBloodPressureDisplayName(BloodPressure BloodPressure)
        {
            return BloodPressure.GetType()?
                    .GetMember(BloodPressure.ToString())?
                    .First()?
                    .GetCustomAttribute<DisplayAttribute>()?
                    .Name;
        }
    }
}
