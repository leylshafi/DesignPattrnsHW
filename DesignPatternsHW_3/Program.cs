
public interface IBuilder
{
    void reset();
    void setSeats(int number);
    void setEngine(int engine);
    void setTripComputer();
    void setGPS();
}

public class CarBuilder : IBuilder
{
    public void reset()
    {
        throw new NotImplementedException();
    }

    public void setEngine(int engine)
    {
        throw new NotImplementedException();
    }

    public void setGPS()
    {
        throw new NotImplementedException();
    }

    public void setSeats(int number)
    {
        throw new NotImplementedException();
    }

    public void setTripComputer()
    {
        throw new NotImplementedException();
    }
}


class Program
{
    static void Main()
    {

    }
}