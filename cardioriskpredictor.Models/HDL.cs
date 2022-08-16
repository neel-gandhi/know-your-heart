using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace cardioriskpredictor.Models
{
    public enum HDL
    {
        [Display(Name = "60 +")]
        SixtyPlus,

        [Display(Name = "50 - 59")]
        FiftyToFiftyNine,

        [Display(Name = "40 - 49")]
        FourtyToFourtyNine,

        [Display(Name = "< 40")]
        BelowFourty
    }

    public class HDLExtension
    {
        public static string GetHDLDisplayName(HDL hdl)
        {
            return hdl.GetType()?
                    .GetMember(hdl.ToString())?
                    .First()?
                    .GetCustomAttribute<DisplayAttribute>()?
                    .Name;
        }
    }
}
