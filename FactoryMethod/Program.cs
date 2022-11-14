namespace FactoryPattern
{



    interface IProduct
    {
        string ShipFrom();
    }


    class ProductA : IProduct
    {
        public string ShipFrom()
        {
            return " from South Africa";
        }
    }

    class ProductB : IProduct
    {
        public string ShipFrom()
        {
            return " from Spain";
        }
    }

    class DefaultProduct : IProduct
    {
        public string ShipFrom()
        {
            return "not available";
        }
    }


    class Creator
    {
        public IProduct FactoryMethod(int month)
            => month switch
            {
                >= 4 and <= 11 => new ProductA(),
                1 or 2 or 12 => new ProductB(),
                _ => new DefaultProduct()
            };
    }


    class Program
    {
        static void Main()
        {
            Creator c = new Creator();
            IProduct product;

            for (int i = 1; i <= 12; i++)
            {
                product = c.FactoryMethod(i);
                Console.WriteLine("Avocados " + product.ShipFrom());
            }
        }
    }
}

// LogisticsApp in Refactoring Guru





//static void Main()
//{
//    // Logistics logistics = new AirLogistics();
//    // ITransport transport = logistics.CreateTransport();
//    // transport.Deliver();






//    Logistics? logistics = null;
//    ITransport? transport = null;

//    while (true)
//    {
//        Console.WriteLine(@"
//							1: Road
//							2: Sea
//							3: Air
//							Any: Exit");

//        Console.Write("\n\tEnter choice: ");


//        logistics = Console.ReadLine() switch
//        {
//            "1" => new RoadLogistics(),
//            "2" => new SeaLogistics(),
//            "3" => new AirLogistics(),
//            _ => null
//        };

//        if (logistics == null)
//            break;


//        transport = logistics?.CreateTransport();
//        transport?.Deliver();
//    }
//}