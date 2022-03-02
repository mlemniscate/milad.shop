using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace milad.Framework.Persistence
{
    public abstract class DbContextBase : DbContext, IDbContext
    {
        public DbContextBase(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            List<dynamic> mappings = DetectEntityMappings();

            mappings.ForEach(m => modelBuilder.Configurations.Add(m));
        }

        protected abstract List<dynamic> DetectEntityMappings();
    }
}
