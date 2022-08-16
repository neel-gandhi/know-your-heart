using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace cardioriskpredictor.Models
{
    public enum AgeGroup
    {
        [Display(Name = "20 - 34")]
        TwentyToThirtyFour,

        [Display(Name = "35 - 39")]
        ThirtyFiveToThirtyNine,

        [Display(Name = "40 - 44")]
        FourtyToFourtyFour,

        [Display(Name = "45 - 49")]
        FourtyFiveToFourtyNine,

        [Display(Name = "50 - 54")]
        FiftyToFiftyFour,

        [Display(Name = "55 - 59")]
        FiftyFiveToFiftyNine,

        [Display(Name = "60 - 64")]
        SixtyToSixtyFour,

        [Display(Name = "65 - 69")]
        SixtyFiveToSixtyNine,

        [Display(Name = "70 - 74")]
        SeventyToSeventyFour,

        [Display(Name = "75 +")]
        SeventyFiveAndAbove
    }

    public class AgeGroupExtension
    {
        public static string GetAgeGroupDisplayName(AgeGroup ageGroup)
        {
            return ageGroup.GetType()?
                    .GetMember(ageGroup.ToString())?
                    .First()?
                    .GetCustomAttribute<DisplayAttribute>()?
                    .Name;
        }
    }
}
