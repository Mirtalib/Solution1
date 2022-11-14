namespace Task;

// LogisticsApp in Refactoring Guru





interface ITransport
{
	void Delivery();
}


public class Truck : ITransport
{
    public void Delivery()
    {
        throw new NotImplementedException();
    }
}


public class Ship : ITransport
{
    public void Delivery()
    {
        throw new NotImplementedException();
    }
}


public abstract class Logistics
{

	public void PlayDelivery()
    {

	}

	public abstract void CreateTransport();

}


public class RoadLogistics : Logistics
{
    public override void CreateTransport()
    {
        throw new NotImplementedException();
    }
}


public class SeaLogistics : Logistics
{
    public override void CreateTransport()
    {
        throw new NotImplementedException();
    }
}

public class AirLogistics : Logistics
{
	public override void CreateTransport()
	{
		throw new NotImplementedException();
	}
}





class Program
{
	static void Main()
	{
		// Logistics logistics = new AirLogistics();
		// ITransport transport = logistics.CreateTransport();
		// transport.Deliver();
		Logistics? logistics = null;

		while (true)
		{
			Console.WriteLine(@"
		 					1: Road
		 					2: Sea
		 					3: Air
		 					Any: Exit");

			Console.Write("\n\tEnter choice: ");


			logistics = Console.ReadLine() switch
			{
				"1" => new RoadLogistics(),
				"2" => new SeaLogistics(),
				"3" => new AirLogistics(),
				_ => null
			};

			if (logistics == null)
				break;


			logistics?.PlayDelivery();
		}
	}
}

