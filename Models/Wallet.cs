using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SavingsPlatformASP.net.Models
{
    public class Wallet : BaseModel
    {
        [Required]
        public long Balance { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public int Currency { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public String WalletType { get; set; }

        [Required]
        public bool Hold { get; set; } = true;

    }
}
