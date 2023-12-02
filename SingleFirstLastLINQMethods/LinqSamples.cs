using LINQSamples.Common;

namespace LINQSamples
{
    public class LinqSamples : ViewModelBase
    {
        #region FirstQuery
        /// <summary>
        /// Locate a specific product using First(). First() searches forward in the collection.
        /// NOTE: First() throws an exception if the result does not produce any values
        /// Use First() when you know or expect the sequence to have at least one element.
        /// Exceptions should be exceptional, so try to avoid them.
        /// </summary>
        public Product FirstQuery()
        {
            var productList = GetProducts();

            // First Query Syntax Here
            var product = (from prod in productList
                           select prod)
                       .First(prod => prod.Color == "Red");

            return product;
        }
        #endregion

        #region FirstMethod
        /// <summary>
        /// Locate a specific product using First(). First() searches forward in the collection.
        /// NOTE: First() throws an exception if the result does not produce any values
        /// Use First() when you know or expect the sequence to have at least one element.
        /// Exceptions should be exceptional, so try to avoid them.
        /// </summary>
        public Product FirstMethod()
        {
            var productList = GetProducts();

            // First Method Syntax Here
            var product = productList.First(prod => prod.Color == "Red");

            return product;
        }
        #endregion

        #region FirstOrDefaultQuery
        /// <summary>
        /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
        /// NOTE: FirstOrDefault() returns a null if no value is found
        /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
        /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
        /// </summary>
        public Product? FirstOrDefaultQuery()
        {
            var productList = GetProducts();

            // FirstOrDefault Query Syntax Here
            var product = (from prod in productList
                           select prod)
                     .FirstOrDefault(prod => prod.Color == "Red");

            return product;
        }
        #endregion

        #region FirstOrDefaultMethod
        /// <summary>
        /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
        /// NOTE: FirstOrDefault() returns a null if no value is found
        /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
        /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
        /// </summary>
        public Product? FirstOrDefaultMethod()
        {
            var productList = GetProducts();

            // FirstOrDefault Method Syntax Here
            var product = productList.FirstOrDefault(prod => prod.Color == "Red");

            return product;
        }
        #endregion

        #region FirstOrDefaultWithDefaultQuery
        /// <summary>
        /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
        /// NOTE: You may specify the return value with FirstOrDefault() if not found
        /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
        /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
        /// </summary>
        public Product FirstOrDefaultWithDefaultQuery()
        {
            var productList = GetProducts();

            // FirstOrDefaultWithDefault Query Syntax Here
            var product = (from prod in productList
                           select prod)
                      .FirstOrDefault(prod => prod.Color == "Red",
                                      new Product { ProductID = -1, Name = "PRODUCT NOT FOUND" });

            return product;
        }
        #endregion

        #region FirstOrDefaultWithDefaultMethod
        /// <summary>
        /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
        /// NOTE: You may specify the return value with FirstOrDefault() if not found
        /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
        /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
        /// </summary>
        public Product FirstOrDefaultWithDefaultMethod()
        {
            var productList = GetProducts();

            // FirstOrDefaultWithDefault Method Syntax Here
            var product = productList.FirstOrDefault(prod => prod.Color == "Red",
                                             new Product { ProductID = -1, Name = "NOT FOUND" });

            return product;
        }
        #endregion

        #region LastQuery
        /// <summary>
        /// Locate a specific product using Last(). Last() searches from the end of the list backwards.
        /// NOTE: Last returns the last value from a collection, or throws an exception if no value is found
        /// </summary>
        public Product LastQuery()
        {
            var productList = GetProducts();

            // Last Query Syntax Here
            var product = (from prod in productList
                           select prod)
                      .Last(prod => prod.Color == "Red");

            return product;
        }
        #endregion

        #region LastMethod
        /// <summary>
        /// Locate a specific product using Last(). Last() searches from the end of the list backwards.
        /// NOTE: Last returns the last value from a collection, or throws an exception if no value is found
        /// </summary>
        public Product LastMethod()
        {
            var productList = GetProducts();

            // Last Method Syntax Here
            var product = productList.Last(prod => prod.Color == "Red");

            return product;
        }
        #endregion

        #region LastOrDefaultQuery
        /// <summary>
        /// Locate a specific product using LastOrDefault(). LastOrDefault() searches from the end of the list backwards.
        /// NOTE: LastOrDefault returns the last value in a collection or a null if no values are found
        /// </summary>
        public Product? LastOrDefaultQuery()
        {
            var productList = GetProducts();

            // LastOrDefault Query Syntax Here
            var product = (from prod in productList
                           select prod)
                      .LastOrDefault(prod => prod.Color == "Red");

            return product;
        }
        #endregion

        #region LastOrDefaultMethod
        /// <summary>
        /// Locate a specific product using LastOrDefault(). LastOrDefault() searches from the end of the list backwards.
        /// NOTE: LastOrDefault returns the last value in a collection or a null if no values are found
        /// NOTE: LastOrDefault returns the last value in a collection or a default value if no values are found-
        /// You may specify the return value with LastOrDefault() if not found-
        /// </summary>
        public Product? LastOrDefaultMethod()
        {
            var products = GetProducts();

            // LastOrDefault Method Syntax Here
            var product = products.LastOrDefault(prod => prod.Color == "Brown");

            return product;
        }
        #endregion

        #region SingleQuery
        /// <summary>
        /// Locate a specific product using Single().
        /// NOTE: Single() expects only a single element to be found in the collection, otherwise an exception is thrown
        /// Single() always searches the complete collection
        /// </summary>
        public Product SingleQuery()
        {
            var productList = GetProducts();

            // Single Query Syntax Here
            var product = (from prod in productList
                           select prod)
                       .Single(prod => prod.ProductID == 706);

            return product;
        }
        #endregion

        #region SingleMethod
        /// <summary>
        /// Locate a specific product using Single().
        /// NOTE: Single() expects only a single element to be found in the collection, otherwise an exception is thrown
        /// Single() always searches the complete collection
        /// </summary>
        public Product SingleMethod()
        {
            var productList = GetProducts();
            Product value;

            // Single Method Syntax Here
            value = productList.Single(prod => prod.ProductID == 706);

            return value;
        }
        #endregion

        #region SingleOrDefaultQuery
        /// <summary>
        /// Locate a specific product using SingleOrDefault()
        /// NOTE: SingleOrDefault() returns a single element found in the collection, or a null value if none found in the collection, if multiple values are found an exception is thrown.
        /// SingleOrDefault() always searches the complete collection
        /// </summary>
        public Product? SingleOrDefaultQuery()
        {
            var productList = GetProducts();

            // SingleOrDefault Query Syntax Here
            var product = (from prod in productList
                           select prod)
                    .SingleOrDefault(prod => prod.ProductID == 706);

            return product;
        }
        #endregion

        #region SingleOrDefaultMethod
        /// <summary>
        /// Locate a specific product using SingleOrDefault() //It use for Locate a specific product
        /// NOTE: SingleOrDefault() returns a single element found in the collection, or a null value if none found in the collection, if multiple values are found an exception is thrown.
        /// SingleOrDefault() always searches the complete collection
        /// </summary>
        ///

        public Product? SingleOrDefaultMethod(int productID)
        {
            var productList = GetProducts();

            // SingleOrDefault Method Syntax Here
            var product = productList
                      .SingleOrDefault(prod => prod.ProductID == productID);

            return product;
        }






        #endregion
    }
}
