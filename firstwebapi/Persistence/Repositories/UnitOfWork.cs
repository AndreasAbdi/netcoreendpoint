using firstwebapi.Domain.Repositories;
using firstwebapi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Persistence.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDatabaseContext _context;
        
        public UnitOfWork(ApplicationDatabaseContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
