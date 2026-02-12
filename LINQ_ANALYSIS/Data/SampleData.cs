using LINQ_ANALYSIS.models;
using System.Collections.Generic;

namespace LINQ_ANALYSIS.Data;

public class SampleData
{
    public List<User> Users { get; } =
    [
        new(1, "Alice"),
        new(2, "Bob"),
        new(3, "Charlie")
    ];

    public List<Category> Categories { get; } =
    [
        new(1, "Electronics"),
        new(2, "Books")
    ];

    public List<Product> Products { get; } =
    [
        new(1, "Laptop", 1, 1500),
        new(2, "Phone", 1, 800),
        new(3, "C# in Depth", 2, 40)
    ];

    public List<Order> Orders { get; } =
    [
        new(1, 1, 1, 1, 10.02),
        new(2, 1, 3, 2, 12.02),
        new(3, 2, 2, 1, 10.01),
        new(4, 3, 3, 3, 27.01)
    ];
}