using System;
using System.ComponentModel.DataAnnotations;

namespace SavingsPlatformASP.net.Models
{
    public class WalletHold :BaseModel
    {
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int WalletId { get; set; }
        public Wallet Wallet { get; set; }

        [Required]
        public DateTime RelaseDay { get; set; }
    }
}
