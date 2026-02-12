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
        foreach (var el in seq)
        {
            Console.WriteLine($"group {el.Key} - Sum = {el.Value}");
        }
    }
}
