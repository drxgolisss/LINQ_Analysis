using System;
using LINQ_ANALYSIS.Data;
using LINQ_ANALYSIS.models;
using LINQ_ANALYSIS.analysis;

class Program
{
    static void Main()
    {
        var data = new SampleData();
        var seq = Analysis.SumbyCategory(data.Categories, data.Products);
        Console.WriteLine("Sum in every group : \n");
        foreach (var el in seq)
        {
            Console.WriteLine($"group {el.Key} - Sum = {el.Value}$");
        }
        
        Console.WriteLine("\n");
        
        var seq1 = Analysis.GroupByCategory(data.Categories, data.Products);
        foreach (var el in seq1)
        {
            Console.WriteLine($"{el.CategoryName} : ");
            if (el.products.Any())
            {
                foreach (var VARIABLE in el.products)
                {
                    Console.WriteLine($"Product name : {VARIABLE.Name}");
                }
            }
            else
            {
                Console.WriteLine("there are no products in this group\n");
            }
        }
        
        Console.WriteLine("Max price in each group : \n");
        var seq2 = Analysis.MaxpriceInGroup(data.Categories, data.Products);
        {
            foreach (var VARIABLE in seq2)
            {
                Console.WriteLine($"group {VARIABLE.Key} : {VARIABLE.Value}$");
            }
            
        }
        
        Console.WriteLine("\n");
        
        var seq3 = Analysis.NumofOrdersPerUser(data.Users, data.Orders);
        {
            foreach (var el in seq3)
            {
                Console.WriteLine($"User {el.Key} - Num of orders: {el.Value}");
            }
        }
        
    }
}
