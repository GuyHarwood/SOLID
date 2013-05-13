using System.Collections.Generic;
using NUnit.Framework;

namespace SOLID.ocp
{
    [TestFixture]
    public class OcpTests
    {
        private ProductFilter filterProduct;
        private IList<Product> products;

        [SetUp]
        public void before_each_spec()
        {
            this.filterProduct = new ProductFilter();
            this.products = this.BuildProducts();
        }

        private IList<Product> BuildProducts()
        {
            return new List<Product>
                               {
                                   new Product(ProductColor.Blue),
                                   new Product(ProductColor.Yellow),
                                   new Product(ProductColor.Yellow),
                                   new Product(ProductColor.Red),
                                   new Product(ProductColor.Blue)
                               };

        }


        [Test]
        public void should_filter_by_the_color_given()
        {
            int foundCount = 0;
            foreach (var product in this.filterProduct.By(this.products, new ColorFilterSpecification(ProductColor.Blue)))
            {
                foundCount++;
            }

            Assert.That(foundCount, Is.EqualTo(2));
        }
    }
}
