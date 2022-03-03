using milad.Framework.Persistence;
using System;

namespace milad.shop.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext context;

        public UnitOfWork(IDbContext context)
        {
            this.context = context;
        }
        public void Commit()
        {
            context.SaveChanges();
        }

        public void Rollback()
        {
            context.Dispose(); // TODO: better design
        }
    }
}
