using System;
using Microsoft.EntityFrameworkCore;

namespace SavingsPlatformASP.net.Models
{
    public class SavingsPlatformDbContext : DbContext
    {
        public SavingsPlatformDbContext(DbContextOptions<SavingsPlatformDbContext> options) : base(options)
        {
        }

        public DbSet<Bank> Bank { get; set; }
        public DbSet<UserBankAccount> UserBankAccounts{ get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Transfer> Transfer { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<WalletFund> WalletFund { get; set; }
        public DbSet<WalletHold> WalletHold { get; set; }
        public DbSet<WalletPolicy> WalletPolicy { get; set; }
    }
}
