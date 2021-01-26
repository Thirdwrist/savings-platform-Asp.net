using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SavingsPlatformASP.net.Models
{
    public class Bank : BaseModel
    {
        [Required]
        [Column(TypeName = "varchar(200)")]
        public int Phone { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public int NBISSCode { get; set; }

        [Required]
        public bool Status { get; set; }

        public List<UserBankAccount> UserBankAccount { get; set; }


    }
}
