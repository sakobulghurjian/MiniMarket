using MiniMarket;

internal class Program
{
    static void Main(string[] args)
    {
        var order = GiveRandomOrder();
        Print(order);
    }

    static Order GiveRandomOrder()
    {
        User u = new User();
        u.Id = 0;
        u.Name = "User1";

        Cashier c = new Cashier();
        c.Id = 1;
        c.Name = "Cashier1";
        c.Salery = 500;

        Product p1 = new Product();
        p1.Id = 0;
        p1.Name = "TV";
        p1.Price = 250000;

        Product p2 = new Product();
        p2.Id = 1;
        p2.Name = "Laptop";
        p2.Price = 500000;

        var p = new List<Product>();
        p.Add(p1);
        p.Add(p2);

        Order o = new Order();
        o.Id = 0;
        o.Seller = c;
        o.Products = p;
        o.Buyer = u;

        return o;
    }

    static void Print(Order o)
    {
        // Creating a file
        string myfile = @"file.txt";

        // Appending the given texts
        using (StreamWriter sw = File.AppendText(myfile))
        {
            sw.WriteLine("{");
            sw.WriteLine("Product_Id :{0}", o.Id);
            sw.WriteLine("Product_Seller :{0}", o.Seller.Name);
            sw.WriteLine("Product_Buyer :{0}", o.Buyer.Name);

            int sum = 0;
            for (int i = 0; i < o.Products.Count; i++)
            {
                sw.WriteLine("{0}-th product :{1}, Price:{2}", i + 1, o.Products[i].Name, o.Products[i].Price);
                sum += o.Products[i].Price;
            }
            sw.WriteLine("Total price :{0}", sum);
            sw.WriteLine("}");
            sw.Close();
        }
    }
}