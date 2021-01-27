using System;
using System.ComponentModel.DataAnnotations;

namespace SavingsPlatformASP.net.Models
{
    public class WalletFund : BaseModel
    {
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public long Amount { get; set; }

        [Required]
        public string Curreny { get; set; }

        [Required]
        public string Method { get; set; }

        [Required]
        public string TransactionRef { get; set; }

    }
}
