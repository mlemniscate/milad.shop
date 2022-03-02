using milad.Framework.Domain;
using System.Data;
using System.Data.Entity.ModelConfiguration;

namespace milad.Framework.Persistence
{
    public abstract class BaseEntityMapping<TEntity> : 
        EntityTypeConfiguration<TEntity>,
        IEntityMapping
        where TEntity : BaseEntity
    {
        protected BaseEntityMapping()
        {
            Property(c => c.Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString())
                .IsRequired();
            HasKey(c => c.Id);

            var schemaName = typeof(TEntity).Namespace.Split(new[] { '.' })[2];
            ToTable(typeof(TEntity).Name, schemaName);
        }
    }
}
