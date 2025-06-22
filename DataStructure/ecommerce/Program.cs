using System;

public class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public override string ToString()
    {
        return $"{ProductId} - {ProductName} - {Category}";
    }
}

public class SearchDemo
{
    public static Product LinearSearch(Product[] products, string targetName)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                return products[i];
        }
        return null;
    }

    public static Product BinarySearch(Product[] products, string targetName)
    {
        int left = 0, right = products.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int comparison = string.Compare(products[mid].ProductName, targetName, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return products[mid];
            else if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    public static void Main(string[] args)
    {
        Product[] unsortedProducts = {
            new Product(1, "Shoes", "Footwear"),
            new Product(2, "Laptop", "Electronics"),
            new Product(3, "T-shirt", "Clothing"),
            new Product(4, "Phone", "Electronics"),
            new Product(5, "Watch", "Accessories")
        };

        Console.WriteLine("Linear Search Result:");
        var result1 = LinearSearch(unsortedProducts, "Phone");
        Console.WriteLine(result1 != null ? result1.ToString() : "Product not found");

        Product[] sortedProducts = {
            new Product(2, "Laptop", "Electronics"),
            new Product(4, "Phone", "Electronics"),
            new Product(1, "Shoes", "Footwear"),
            new Product(3, "T-shirt", "Clothing"),
            new Product(5, "Watch", "Accessories")
        };

        Array.Sort(sortedProducts, (a, b) => a.ProductName.CompareTo(b.ProductName));

        Console.WriteLine("\nBinary Search Result:");
        var result2 = BinarySearch(sortedProducts, "Phone");
        Console.WriteLine(result2 != null ? result2.ToString() : "Product not found");
    }
}
