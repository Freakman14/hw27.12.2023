public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
public class Phone : Product
{
    public string Models { get; set; }
    public string Company { get; set; }
}
public class Car : Product
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public int Year { get; set; }
}

public class Shop
{
    List<Product> cip = new List<Product>() { };

    public void AddProduct(Product product)
    {
        cip.Add(product);
    }
    public void RemoveProduct(Product product)
    {
        cip.Remove(product);
    }
    public void PrintProduct()
    {
        foreach (var item in cip)
        {
            System.Console.WriteLine(item.Name);
            System.Console.WriteLine(item.Price);
            System.Console.WriteLine("------------");
        }
        System.Console.WriteLine("+++++++++++++++++");
    }
}