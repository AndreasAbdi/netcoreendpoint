﻿using firstwebapi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);

        Task<Category> FindByIdAsync(int id);
        void Update(Category category);

        void deleteAsync(Category category);
    }
}
