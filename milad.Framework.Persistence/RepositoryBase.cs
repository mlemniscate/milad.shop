using milad.Framework.Core.Domain;
using milad.Framework.Domain;
using System;
using System.Data.Entity;
using System.Linq;

namespace milad.Framework.Persistence
{
    public abstract class RepositoryBase<TAggregateRoot> 
        where TAggregateRoot : BaseEntity, IAggregateRoot<TAggregateRoot>, new()
    {
        private readonly DbContextBase dbContext;

        public RepositoryBase(IDbContext dbContext)
        {
            this.dbContext = dbContext as DbContextBase;
        }

        protected DbSet<TAggregateRoot> Set
        {
            get
            {
                var set = dbContext.Set<TAggregateRoot>().AsQueryable();
                var includeExpressions = new TAggregateRoot().GetAggregateExpressions();
                foreach (var expression in includeExpressions)
                {
                    set = set.Include(expression);
                }
                return (DbSet<TAggregateRoot>)set;
            }
        }

        protected TAggregateRoot GetById(Guid id)
        {
            return Set.Single(t => t.Id == id);
        }
    }
}
