using P225NLayerArchitectura.Core.Entities;
using P225NLayerArchitectura.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace P225NLayerArchitectura.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context):base(context)
        {

        }
    }
}
