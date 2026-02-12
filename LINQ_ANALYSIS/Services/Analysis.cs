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
                .ToDictionary(g => g.Key
                    , g => (double)g.Sum(p => p.Price));
            return seq;
        }

        public static Dictionary<int,double> AvgPriceByCategory(IEnumerable<Category> cat, IEnumerable<Product> prod)
        {
            var seq = prod
                .GroupBy(p => p.CategoryId)
                .Select(g =>
                    new { GroupKey = g.Key, average = g.Average(f => f.Price) })
                .ToDictionary(g => g.GroupKey, g => (double)g.average);
            return seq;
        }

        public static Dictionary<int, double> MaxpriceInGroup(IEnumerable<Category> cat, IEnumerable<Product> prod)
        {
            var seq = prod
                .GroupBy(p => p.CategoryId)
                .Select(g
                    => new { GroupKey = g.Key, max = g.Max(f => f.Price) })
                .ToDictionary(g => g.GroupKey, g => (double)g.max);
            return seq;
        }

        public static Dictionary<int, int> NumofOrdersPerUser(IEnumerable<User> user, IEnumerable<Order> order)
        {
            var seq = order
                .GroupBy(o => o.UserId)
                .ToDictionary(f => f.Key, f => f.Count());
            return seq;
        }
    }
    
        
}
