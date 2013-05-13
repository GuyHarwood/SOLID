using System.Collections.Generic;

namespace SOLID.ocp
{
    public abstract class ProductFilterSpecification
    {
        public IEnumerable<Product> Filter(IList<Product> products)
        {
            return this.ApplyFilter(products);
        }

        protected abstract IEnumerable<Product> ApplyFilter(IList<Product> products);
    }
}