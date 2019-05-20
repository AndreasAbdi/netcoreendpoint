using firstwebapi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly ApplicationDatabaseContext _context;

        public BaseRepository(ApplicationDatabaseContext context)
        {
            _context = context;
        }
    }
}
