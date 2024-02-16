using System.Configuration;
using System.Data.Entity;
using EmailSenderMVC.Models.Domains;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EmailSenderMVC.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Email> Emails { get; set; }
        public DbSet<SentEmailAcountParams> SentEmailAcountParamss { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(x => x.Emails)
                .WithRequired(x => x.User)
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicationUser>()
               .HasMany(x => x.SentEmailAcountParamss)
               .WithRequired(x => x.User)
               .HasForeignKey(x => x.UserId)
               .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}