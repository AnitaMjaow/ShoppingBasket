internal class Product
{
    // input variables to store values given by the user
    private string name; // name of the product as text
    private double price; // price as reel number (with or without decimals)
    private int count; // quantity of the product as a whole number

    // out variable
    private double amountToPay;

    // Method to read all input values
    public void Start()
    {
        ReadInput();
        CalculateAmountToPay();
        PrintReceipt();
    }

    // Method to read the name, price, and quantity
    private void ReadInput()
    {
        ReadName();  
        ReadPrice(); 
        ReadQuantity();
    }

    private void ReadName()
    {
        // prompt the user
        Console.WriteLine("Name of the product? ");

        // read and save the text the user writes using the keyboard
        name = Console.ReadLine();
        Console.WriteLine(); // blank line
        Console.WriteLine("Thanks " + name + "!");
    }

    private void ReadPrice()
    {
        Console.WriteLine("Price? ");
        string strPrice = Console.ReadLine(); // local variable
        price = double.Parse(strPrice); // conversion to a number
        Console.WriteLine(); // blank line
        Console.WriteLine("The price of " + name + " is " + price + ".");
    }

    private void ReadQuantity()
    {
        Console.WriteLine("Quantity of the product? ");
        string strQuantity = Console.ReadLine();
        count = int.Parse(strQuantity);
        Console.WriteLine();
        Console.WriteLine("The number of this product is " + count);
    }

    // Method to calculate the total amount to pay
    private void CalculateAmountToPay()
    {
        amountToPay = price * count;
    }

    // Method to print the receipt
    private void PrintReceipt()
    {
        Console.WriteLine("*** Receipt ***");
        Console.WriteLine("Unit price : " + price);
        Console.WriteLine("Quantity : " + count);
        Console.WriteLine("Amount to pay : " + amountToPay.ToString("0.00"));
        Console.WriteLine();
        Console.WriteLine("*** Welcome back! ***");
    }
}
