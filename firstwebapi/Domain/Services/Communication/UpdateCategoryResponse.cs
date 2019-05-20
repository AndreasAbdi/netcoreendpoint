using firstwebapi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Domain.Services.Communication
{
    public class UpdateCategoryResponse : BaseResponse
    {

        public Category Category { get; private set; }

        private UpdateCategoryResponse(bool success, string message, Category category): base(success, message)
        {
            Category = category;
        }

        public UpdateCategoryResponse(Category category) : this(true, string.Empty, category)
        {
            Category = category;
        }

        public UpdateCategoryResponse(string message): this(false, message, null) { }
    }
}
