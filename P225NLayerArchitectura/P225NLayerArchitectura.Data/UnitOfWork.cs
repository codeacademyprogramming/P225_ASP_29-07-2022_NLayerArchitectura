using P225NLayerArchitectura.Core;
using P225NLayerArchitectura.Core.Repositories;
using P225NLayerArchitectura.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P225NLayerArchitectura.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CategoryRepository categoryRepository;
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public ICategoryRepository CategoryRepository => categoryRepository != null ? categoryRepository : new CategoryRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
