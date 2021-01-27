using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SavingsPlatformASP.net.Models
{
    public class Transaction : BaseModel
    {

        public enum TransactionTypeEnum
        {
            DEBIT,
            CREDIT
        }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int WalletId { get; set; }
        public Wallet Wallet { get; set; }

        [Required]
        public long CurrentBalance { get; set; }

        [Required]
        public long InitialWallet { get; set; }

        [Required]
        public string Currency { get; set;}

        [Required]
        public TransactionTypeEnum TransactionType { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        [Column(TypeName = "varchar(1000)")]
        public string ModelType { get; set; }

        [Required]
        public string ModelId { get; set; }

    }
}
