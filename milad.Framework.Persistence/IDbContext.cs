using System;

namespace milad.Framework.Persistence
{
    public interface IDbContext : IDisposable
    {
        int SaveChanges();
    }
}
