using System;

public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer = new Customer();

    public Order()
    {
        Random random = new Random();

        int amountOfProducts = random.Next(3, 5);
        int productsCount = 0;
        while (productsCount < amountOfProducts)
        {
            var product = new Product();
            _productList.Add(product);
            productsCount += 1;
        }
    }

    private double getTotalPrice()
    {
        double totalPrice = 0.0;

        foreach (Product product in _productList)
        {
            totalPrice += product.quantityCost();
        }

        // totalPrice += quantityCost;
        if (_customer.getUSAStatus() == true)
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }

    public void printPackingLabel()
    {
        // var product = new Product();
        double total = 0.0;
        foreach (Product product in _productList)
        {
            double totalPrice = getTotalPrice();
            Console.WriteLine(product.getProductInfo());
            Console.WriteLine("$" + product.quantityCost());
            Console.WriteLine();
            // productLabels.Add(product.getProductInfo());
        }

        foreach (Product product in _productList)
        {
            // Console.WriteLine(product.getProductInfo());
            // Console.WriteLine("Product Total: $" + product.quantityCost());
            // Console.WriteLine();
            total += getTotalPrice();
        }
        Console.WriteLine($"Total Price: ${Math.Round(total, 2)}");
    }

    public void printShippingLabel()
    {
        Console.WriteLine(_customer.getCustomerInfo());
        Console.WriteLine();
    }
}