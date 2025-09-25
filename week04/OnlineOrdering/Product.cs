using System;

public class Product
{
    private string _name;
    private long _productId;
    private double _price;
    private int _quantity;


    public Product()
    {
        Random random = new Random();

        string[] names = {
            "Wireless Mouse",
            "Mechanical Keyboard",
            "Noise-Cancelling Headphones",
            "4K Monitor",
            "USB-C Hub",
            "Gaming Chair",
            "RGB Strip Light",
            "Phone Stand",
            "Desk Fan"
        };

        double[] prices = {
            29.99,
            89.99,
            129.99,
            349.99,
            49.99,
            199.99
        };

        int[] quantityChoice = {
            2,
            15,
            1,
            3,
            1
        };

        List<int> idDigits = new List<int>();
        int idDigitCount = 0;
        do
        {
            int newDigit = random.Next(1, 9);
            idDigits.Add(newDigit);
            idDigitCount += 1;
        } while (idDigitCount < 12);
        string combinedId = string.Join("", idDigits);


        _name = names[random.Next(names.Length)];
        _productId = long.Parse(combinedId);
        _price = prices[random.Next(prices.Length)];
        _quantity = quantityChoice[random.Next(quantityChoice.Length)];
    }

    public double quantityCost()
    {
        return Math.Round(_price, 2) * _quantity;
    }

    public string getProductInfo()
    {
        return $"{_name}, ID:{_productId}\n Item Count: {_quantity}";
    }
}