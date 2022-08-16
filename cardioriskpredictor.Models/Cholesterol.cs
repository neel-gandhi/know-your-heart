using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace cardioriskpredictor.Models
{
    public enum Cholesterol
    {
        [Display(Name = "< 160")]
        OneSixtyOrLess,

        [Display(Name = "160 - 199")]
        OneSixtyToOneNintyNine,

        [Display(Name = "200 - 239")]
        TwoHundredToTwoThirtyNine,

        [Display(Name = "240 - 279")]
        TwoFourtyToTwoSeventyNine,

        [Display(Name = "280 +")]
        TwoEightyPlus
    }

    public class CholesterolExtension
    {
        public static string GetCholesterolDisplayName(Cholesterol cholesterol)
        {
            return cholesterol.GetType()?
                    .GetMember(cholesterol.ToString())?
                    .First()?
                    .GetCustomAttribute<DisplayAttribute>()?
                    .Name;
        }
    }
}
