using System.Collections.Generic;
using System.Linq;
using LINQ_ANALYSIS.models;


public class CategoryReport
{
    public string CategoryName{ get; init; }
    public IEnumerable<Product> products { get; init; }

    public CategoryReport(string categoryName, IEnumerable<Product> Products)
    {
        CategoryName = categoryName;
        products = Products;
    }
}