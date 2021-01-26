using System;
using System.ComponentModel.DataAnnotations;

namespace SavingsPlatformASP.net.Models
{
    public class Transfer : BaseModel
    {
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int WalletId { get; set; }
        public Wallet Wallet { get; set; }

        [Required]
        public int Amount { get; set;}

        [Required]
        public int UserBankAccountId { get; set;}
        public UserBankAccount UserBankAccount {get; set;}
        public int UserId { get; set;}
        public int UserId { get; set;}

    }
}
