using System;
using System.ComponentModel.DataAnnotations;

namespace SavingsPlatformASP.net.Models
{
    public class WalletPolicy : BaseModel
    {

        public enum ReleaseIntervalEnum
        {
            DAY,
            WEEK,
            MONTH,
            YEAR
        }

        [Required]
        public string Name { get; set;}

        public string Description { get; set;}

        [Required]
        public ReleaseIntervalEnum ReleaseInterval { get; set;}

        public int ReleaseIntervalCount { get; set; }

        public int ReleaseCountPerYear { get; set; }

        public bool CanReleaseOnNonReleaseDay { get; set; }

        public int ReleaseOnNonReleaseDayPenalty { get; set;}

        [Required]
        public int Interest { get; set;}

        public bool Hold { get; set;}

        public bool CanBreakHold { get; set;}

        public int HoldBreakPenalty { get; set;}

        [Required]
        public string Currency { get; set;}

        public string IconImage { get; set; }

        public string Banner { get; set; }
    }
}
