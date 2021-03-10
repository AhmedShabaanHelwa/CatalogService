using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Repositories
{
    /// <summary>
    /// Interface for repository pattern
    /// </summary>
    public interface IRepository
    {
        public IUnitOfWork UnitOfWork { get; }
    }
}
