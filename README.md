LINQ_ANALYSIS
LINQ_ANALYSIS is a C# console project demonstrating practical usage of LINQ for grouping, joining, and aggregation.
Project Structure
• Models: Category, Product, Order, User
• Data: SampleData (mock data source)
• Services:
   - Analysis.cs (LINQ logic)
   - CategoryReport.cs (DTO for grouped results)
• Program.cs (entry point)
Implemented Features
1. GroupByCategory
   Uses LINQ GroupJoin to perform a LEFT JOIN between categories and products. Returns IEnumerable<CategoryReport>.
2. SumByCategory
   Uses LINQ GroupBy and ToDictionary to calculate total product price per category. Returns Dictionary<int, double>.
Technologies Used
• C#
• .NET
• LINQ
Concepts Demonstrated
• IEnumerable<T>
• Deferred execution
• Grouping and aggregation
• LEFT JOIN in LINQ
How to Run
1. Open the solution in Rider or Visual Studio.
2. Build the project.
3. Run Program.cs.
4. Observe grouped reports and summaries in console output.
Learning Purpose
This project is designed to practice LINQ fundamentals and understand how grouping and aggregation work internally in C#.

