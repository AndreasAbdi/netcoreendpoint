using firstwebapi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Domain.Services.Communication
{
    public class DeleteCategoryResponse : BaseResponse
    {
        public Category Category { get; private set; }

        private DeleteCategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }

        public DeleteCategoryResponse(Category category) : this(true, string.Empty, category)
        {
            Category = category;
        }

        public DeleteCategoryResponse(string message) : this(false, message, null) { }
    }
}
