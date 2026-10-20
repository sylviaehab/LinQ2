using LinQ2.DataSources;
using LinQ2.Models;
using System.Diagnostics.Metrics;
using static LinQ2.DataSources.Source;

namespace LinQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = ProductList.
            //    OrderByDescending(p => p.UnitPrice).
            //    Take(3);
            //foreach(var p in result)
            //{
            //    Console.WriteLine($"Product: {p.ProductName}, Price: {p.UnitPrice}");
            //}


            //var result = ProductList.
            //    Skip(5)
            //    .Take(5);
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"Product: {p.ProductName}, Price: {p.UnitPrice}");
            //}

            //var result = ProductList.
            //    OrderBy(p => p.UnitPrice)
            //    .Where(p => p.UnitPrice <25);

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            //var result = ProductList.
            //    Where(p => p.Category == "SeaFood").
            //    All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result);



            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);


            // var result = ProductList.
            //     GroupBy(p => p.Category);

            //foreach(var g in result)
            // {
            //     Console.WriteLine($"{g.Key}: {g.Count()} products");

            // }

            //var result=ProductList.
            //    GroupBy(p => p.Category).
            //    Select(p => new { Category = p.Key, ProductName= p.Select(p => p.ProductName) });

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);

            //    foreach (var name in group.ProductName)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            //var result = ProductList.
            //    GroupBy(p => p.Category).
            //    Where(p => p.Count() > 3).
            //    Select(p => p.Key);
            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}

            //var result = from c in CustomerList
            //             group c by c.Country into countryGroup
            //             select new
            //             {
            //                 Country = countryGroup.Key,
            //                 Count = countryGroup.Count(),
            //                 TotalOrderValue = countryGroup
            //.SelectMany(c => c.Orders)
            //.Sum(o => o.Total)
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(
            //        $"{item.Country} - Customers: {item.Count} - Total: {item.TotalOrderValue}");
            //}

            //var result=ProductList.
            //    Sum(p => p.UnitsInStock );
            //Console.WriteLine(result);


            // var cheapest = ProductList
            //.Min(p => p.UnitPrice);
            // var mostExpensive = ProductList
            //     .Max(p => p.UnitPrice);
            // Console.WriteLine($"Cheapest: {cheapest}");
            // Console.WriteLine($"Most Expensive: {mostExpensive}");


            //var result = ProductList.
            //    DistinctBy(p => p.Category);


            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}


            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };


            //var result = setA.Except(setB);
            //foreach (var id in result)
            //{
            //    Console.WriteLine(id);
            //}

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result=list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var country in result)
            //{
            //    Console.WriteLine(country);
            //}

            //        Dictionary<int, Product> products = ProductList
            //.ToDictionary(p => p.ProductID);

            //        if (products.TryGetValue(18, out Product product))
            //        {
            //            Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //        }



            //var result=ProductList.
            //First(p => p.UnitPrice > 50);
            //Console.WriteLine($"{result.ProductName} - {result.UnitPrice}");




            //         var result = ProductList.
            //        FirstOrDefault(p => p.UnitPrice > 50);

            //        Console.WriteLine($"{result.ProductName} - {result.UnitPrice}");

            //        var result1 = Enumerable.Range(1, 10)
            //.Select(n => 7 * n);

            //        foreach (var number in result1)
            //        {
            //            Console.WriteLine(number);
            //        }

            //var result =Enumerable.Range(1,30)
            //    .Where(n => n%2==0 );

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}


            //var result =ProductList.
            //    Take(3).
            //    Select(p =>  p.ProductName)
            //    .Concat(
            //    CustomerList.
            //    Take(3).
            //    Select(c => c.CompanyName)
            //    );
            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            var result = ProductList
      .Zip(
          CustomerList,
          (p, c) => $"{p.ProductName} sold to {c.CompanyName
          }"
      );

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
