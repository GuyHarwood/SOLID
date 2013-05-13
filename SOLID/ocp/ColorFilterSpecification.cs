using System.Collections.Generic;

namespace SOLID.ocp
{
    public class ColorFilterSpecification : ProductFilterSpecification
    {
        private readonly ProductColor productColor;

        public ColorFilterSpecification(ProductColor productColor)
        {
            this.productColor = productColor;
        }

        protected override IEnumerable<Product> ApplyFilter(IList<Product> products)
        {
            foreach (var product in products)
            {
                if (product.Color == this.productColor)
                    yield return product;
            }
        }
    }
}