using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Domain.Entities;

namespace T_Zaika.DataAccess.Context
{
    public class TZaikaContext:DbContext
    {

        #region TZaikaContext

        public DbSet<T_USER> T_USER { get; set; }
        public DbSet<T_ROLES> T_USER_PROFILE { get; set; }
        public DbSet<T_USER_ROLES> T_USER_ROLES { get; set; }
        public DbSet<T_SECURITY> T_SECURITY { get; set; }
        public DbSet<T_ROLE_SECURITIES> T_ROLE_SECURITIES { get; set; }
        public DbSet<T_ZAIKABE_MEMBERS> T_ZAIKABE_MEMBERS { get; set; }

        public DbSet<T_PARISHS> T_PARISHS { get; set; }

        public DbSet<T_DISTRICTS> T_DISTRICTS { get; set; }

        public DbSet<T_MEMBER_RESPONSABILITIES> T_MEMBER_RESPONSABILITIES { get; set; }

        public DbSet<T_ZAIKABE_PROGRAMMES> T_ZAIKABE_PROGRAMMES { get; set; }

        public DbSet<T_USER_ASSIGN_PROGRAMMS> T_USER_ASSIGN_PROGRAMMS { get; set; }

        public DbSet<T_ZAIKABE_FUNDING> T_ZAIKABE_FUNDING { get; set; }

        public DbSet<T_LODGMENTS> T_LODGMENTS { get; set; }

        public DbSet<T_MEMBER_PLACES> T_MEMBER_PLACES { get; set; }

        public DbSet<T_CONTRIBUTIONS> T_CONTRIBUTIONS { get; set; }

        public DbSet<T_CONTRIBUTION_TYPES> T_CONTRIBUTION_TYPES { get; set; }

        public DbSet<T_MEMBER_GROUPS> T_MEMBER_GROUPS { get; set; }

        #endregion

        public TZaikaContext(DbContextOptions<TZaikaContext> options) : base(options)
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            TZaikaModelConfiguration.ModelConfiguration(modelBuilder);
            // ModelBuilderExtensions.Seed(modelBuilder);
        }


    }

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Country>().HasData(
            //    new Country
            //    {
            //        Id = 1,
            //        Name = "Venezuela",
            //        Population = 300000000,
            //        Area = 230103

            //    },
            //    new Country
            //    {
            //        Id = 2,
            //        Name = "Peru",
            //        Population = 260000000,
            //        Area = 33249

            //    }

            //);


        }
    }
}
