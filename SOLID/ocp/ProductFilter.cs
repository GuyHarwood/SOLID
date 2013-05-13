using System;
using System.Collections.Generic;

namespace SOLID.ocp
{
    public class ProductFilter
    {
        #region obsolete
        [Obsolete("This method is obsolete; use method 'By' with ProductFilterSpecification")]
        public IEnumerable<Product> ByColor(IList<Product> products, ProductColor productColor)
        {
            foreach (var product in products)
            {
                if (product.Color == productColor)
                    yield return product;
            }
        }

        [Obsolete("This method is obsolete; use method 'By' with ProductFilterSpecification")]
        public IEnumerable<Product> ByColorAndSize(IList<Product> products,
                                                   ProductColor productColor,
                                                   ProductSize productSize)
        {
            foreach (var product in products)
            {
                if ((product.Color == productColor) &&
                    (product.Size == productSize))
                    yield return product;
            }
        }

        [Obsolete("This method is obsolete; use method 'By' with ProductFilterSpecification")]
        public IEnumerable<Product> BySize(IList<Product> products,
                                           ProductSize productSize)
        {
            foreach (var product in products)
            {
                if ((product.Size == productSize))
                    yield return product;
            }
        } 
        #endregion

        public IEnumerable<Product> By(IList<Product> products, ProductFilterSpecification filterSpecification)
        {
            return filterSpecification.Filter(products);
        }
    }
}