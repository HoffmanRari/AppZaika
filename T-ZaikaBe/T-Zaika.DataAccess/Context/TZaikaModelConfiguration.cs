using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Domain.Entities;

namespace T_Zaika.DataAccess.Context
{
    public class TZaikaModelConfiguration
    {
        public static void ModelConfiguration(ModelBuilder modelBuilder)
        {
            // for USER
            modelBuilder.Entity<T_USER>().Property(c => c.Id).HasColumnName("USER_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_ROLES>().Property(c => c.Id).HasColumnName("ROLE_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_USER_ROLES>().Property(c => c.Id).HasColumnName("USER_ROLE_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_SECURITY>().Property(c => c.Id).HasColumnName("SECURITY_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_ROLE_SECURITIES>().Property(c => c.Id).HasColumnName("ROLE_SECURITY_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_ZAIKABE_MEMBERS>().Property(c => c.Id).HasColumnName("MEMBER_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_PARISHS>().Property(c => c.Id).HasColumnName("PARISH_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_MEMBER_RESPONSABILITIES>().Property(c => c.Id).HasColumnName("RESPONSABILITY_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_DISTRICTS>().Property(c => c.Id).HasColumnName("DISTRICT_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_ZAIKABE_PROGRAMMES>().Property(c => c.Id).HasColumnName("PROGRAMME_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_USER_ASSIGN_PROGRAMMS>().Property(c => c.Id).HasColumnName("ASSIGN_PROGRAMM_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_ZAIKABE_FUNDING>().Property(c => c.Id).HasColumnName("FUNDING_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_LODGMENTS>().Property(c => c.Id).HasColumnName("LODGMENT_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_MEMBER_PLACES>().Property(c => c.Id).HasColumnName("MEMBER_PLACE_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_CONTRIBUTIONS>().Property(c => c.Id).HasColumnName("CONTRIBUTION_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_CONTRIBUTION_TYPES>().Property(c => c.Id).HasColumnName("CONTRIBUTION_TYPE_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_MEMBER_GROUPS>().Property(c => c.Id).HasColumnName("GROUP_ID").HasColumnType("bigint").IsRequired();
            modelBuilder.Entity<T_EXPENSE_MANAGEMENTS>().Property(c => c.Id).HasColumnName("EXPENSE_ID").HasColumnType("bigint").IsRequired();

            modelBuilder.Entity<T_ZAIKABE_MEMBERS>().HasOne<T_PARISHS>(p => p.T_PARISHS).WithMany(z => z.T_ZAIKABE_MEMBERS).HasForeignKey(p => p.PARISH_ID);
            modelBuilder.Entity<T_ZAIKABE_MEMBERS>().HasOne<T_MEMBER_GROUPS>(g => g.T_MEMBER_GROUPS).WithMany(z => z.T_ZAIKABE_MEMBERS).HasForeignKey(g => g.GROUP_ID);
            modelBuilder.Entity<T_ZAIKABE_MEMBERS>().HasOne<T_MEMBER_RESPONSABILITIES>(r => r.T_MEMBER_RESPONSABILITIES).WithMany(z => z.T_ZAIKABE_MEMBERS).HasForeignKey(g => g.RESPONSABILITY_ID);
            modelBuilder.Entity<T_PARISHS>().HasOne<T_DISTRICTS>(d => d.T_DISTRICTS).WithMany(p => p.T_PARISHS).HasForeignKey(p => p.DISTRICT_ID);
            modelBuilder.Entity<T_USER_ASSIGN_PROGRAMMS>().HasKey(uap => new { uap.MEMBER_ID, uap.PROGRAMME_ID });
            modelBuilder.Entity<T_ROLE_SECURITIES>().HasKey(rs => new { rs.ROLE_ID, rs.SECURITY_ID });
            modelBuilder.Entity<T_MEMBER_PLACES>().HasKey(mp => new { mp.MEMBER_ID, mp.LODGMENT_ID });
            modelBuilder.Entity<T_CONTRIBUTIONS>().HasKey(c => new { c.MEMBER_ID, c.CONTRIBUTION_TYPE_ID });
            modelBuilder.Entity<T_EXPENSE_MANAGEMENTS>().HasOne<T_ZAIKABE_MEMBERS>(z => z.T_ZAIKABE_MEMBERS).WithMany(e => e.T_EXPENSE_MANAGEMENT).HasForeignKey(m => m.MEMBER_ID);


        }
    }
}
