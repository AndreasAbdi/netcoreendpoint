using firstwebapi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Domain.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();

    }
}
