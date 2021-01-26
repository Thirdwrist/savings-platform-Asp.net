using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SavingsPlatformASP.net.Models
{
    public class Wallet : BaseModel
    {
        public int balance { get; set; }
    }
}
