using BestStore.Shared.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestStore.Shared.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; } = null!;
    }
}
