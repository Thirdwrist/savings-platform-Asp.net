using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SavingsPlatformASP.net.Models
{
    public class User : BaseModel
    {
        [Column(TypeName = "varchar(200)")]
        public int Phone { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public String Username { get; set; }

        [Column(TypeName = "varchar(200)")]
        public int Bvn { get; set; }

        [Column(TypeName = "varchar(400)")]
        public String ProfileAvater { get; set; }

        [Required]
        [Column(TypeName = "varchar(500)")]
        public String Password { get; set; }

        public List<Wallet> Wallet {get; set;}
        public List<WalletFund> WalletFund {get; set;}


       
    }
}

