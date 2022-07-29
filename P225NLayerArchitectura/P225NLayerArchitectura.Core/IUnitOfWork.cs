using P225NLayerArchitectura.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P225NLayerArchitectura.Core
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        Task<int> CommitAsync();
        int Commit();
    }
}
