using System.Collections.Generic;
using System.Linq;
using LINQ_ANALYSIS.models;

namespace LINQ_ANALYSIS.analysis
{
    public static class Analysis
    {
        public static IEnumerable<CategoryReport> GroupByCategory(IEnumerable<Category> cat, IEnumerable<Product> prod)
        {
            var seq = cat.GroupJoin(prod,
                c => c.Id, prods => prods.CategoryId,
                (c, prods) => new CategoryReport(c.Name, prods));
            return seq;
        }

        public static Dictionary<int,double> SumbyCategory(IEnumerable<Category> cat, IEnumerable<Product> prod)
        {
            var seq = prod
                .GroupBy(p => p.CategoryId)
                .ToDictionary(g => g.Key, g => (double)g.Sum(p => p.Price));
            return seq;
        }
    }
}
