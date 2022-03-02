using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace milad.Framework.Domain
{
    public interface IAggregateRoot<TAggregateRoot>
    {
        IEnumerable<Expression<Func<TAggregateRoot, dynamic>>> GetAggregateExpressions();
    }
}
