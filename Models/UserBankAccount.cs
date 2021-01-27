using System;
using System.ComponentModel.DataAnnotations;

namespace SavingsPlatformASP.net.Models
{
    public class UserBankAccount : BaseModel
    {
        [Required]
        public int BankId { get; set;}
        public Bank Bank { get; set; }

        [Required]
        public int UserId { get; set;}
        public User User { get; set;}

        [Required]
        public int AccountNumber { get; set;}

        [Required]
        public int AccountName { get; set;}
    }
}
