using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.DataAccess.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TZaikaContext>
    {
        public TZaikaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TZaikaContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TZaikaDb;User ID=hoffman;Password=;");
            return new TZaikaContext(optionsBuilder.Options);
        }
    }
}
