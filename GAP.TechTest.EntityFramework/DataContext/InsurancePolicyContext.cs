using GAP.TechTest.Core.Entities.Common;
using GAP.TechTest.Core.Entities.InsurancePolicies;
using GAP.TechTest.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.TechTest.EntityFramework.DataContext
{
    public partial class InsurancePolicyContext : DataContext
    {
        static InsurancePolicyContext()
        {
            // Will drop and recreate the database (for development, uncomment)
            Database.SetInitializer(new InitializerForInsurancePolicyContext());            
            //Database.SetInitializer<InsurancePolicyContext>(null);
        }

        public InsurancePolicyContext() : base("Name=InsurancePolicyContext") { }
        
        public DbSet<Coverage> Coverage { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicy { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<UserPolicy> UserPolicy { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();                     
            base.OnModelCreating(modelBuilder);
        }

    }

    public class InitializerForInsurancePolicyContext : DropCreateDatabaseIfModelChanges<InsurancePolicyContext>
    {
        protected override void Seed(InsurancePolicyContext context)
        {
            #region User
            context.User.Add(new User {Id = Guid.NewGuid(), Name = "Admin", Surname="Admin", UserName="admin", IsActive= true, EmailAddress = "admin@test.com", Password="123qwe", CreationTime = DateTime.Now});
            context.User.Add(new User { Id = Guid.NewGuid(), Name = "Test", Surname = "Test", UserName = "test", IsActive = true, EmailAddress = "test@test.com", Password = "123qwe", CreationTime = DateTime.Now});           
            #endregion


            try
            {                
                context.SaveChanges();
            }
            catch (DbEntityValidationException ee)
            {
            }

        }

    }
}
