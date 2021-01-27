using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SavingsPlatformASP.net.JWTAuthentication;

namespace SavingsPlatformASP.net.Models
{
    public class SavingsPlatformDbContext : IdentityDbContext<ApplicationUser>
    {
        public SavingsPlatformDbContext(DbContextOptions<SavingsPlatformDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
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
