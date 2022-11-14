namespace Prototype;


abstract class AbstractWather
{
    

}

abstract class AbstractBottle
{
    public abstract void Intercat(AbstractWather wather);
}

abstract class AbstractFactory 
{
    public abstract AbstractWather CreateWather();
    public abstract AbstractBottle CreateBottle();
}

class CocaColaBottle : AbstractBottle
{
    public override void Intercat(AbstractWather wather)
    {
        throw new NotImplementedException();
    }
}
class CocaColaWather : AbstractWather 
{
    
}


class CocaColaFactory : AbstractFactory
{
    public override AbstractBottle CreateBottle()
    {
        throw new NotImplementedException();
    }

    public override AbstractWather CreateWather()
    {
        throw new NotImplementedException();
    }
}




class Client 
{
    AbstractBottle wather = null!;
    AbstractWather watherFactory = null!;

    public Client(AbstractBottle wather, AbstractWather watherFactory)
    {
        this.wather = wather;
        this.watherFactory = watherFactory;
    }
}

class Program
{
    static void Main()
    {

    }
}

























