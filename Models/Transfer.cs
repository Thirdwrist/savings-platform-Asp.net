using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SavingsPlatformASP.net.Models
{
    public class Transfer : BaseModel
    {
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int WalletId { get; set; }
        public Wallet Wallet { get; set; }

        [Required]
        public int Amount { get; set;}

        [Required]
        public int UserBankAccountId { get; set;}
        public UserBankAccount UserBankAccount {get; set;}

        [Required]
        public int BankId { get; set; }
        public Bank Bank { get; set; }

        [Required]
        public string Currency { get; set;}

        [Required]
        public string Status { get; set;}

    }
}
