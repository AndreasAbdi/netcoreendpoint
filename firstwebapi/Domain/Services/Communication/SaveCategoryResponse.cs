using firstwebapi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Domain.Services.Communication
{
    public class SaveCategoryResponse : BaseResponse
    {

        public Category Category { get; private set; }

        private SaveCategoryResponse(bool success, string message, Category category): base(success, message)
        {
            Category = category;
        }

        public SaveCategoryResponse(Category category) : this(true, string.Empty, category)
        {
            Category = category;
        }

        public SaveCategoryResponse(string message): this(false, message, null) { }
    }
}
