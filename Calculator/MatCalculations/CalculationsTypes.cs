namespace DefaultNamespace.MatCalculations;

public class Addition : ImatTypes
{
    public double getValue(double a, double b)
    {
        return a + b;
    }
}


 
public class Substraction : ImatTypes
{
    public double getValue(double a, double b)
    {
        return a - b;
    }
}  



public class Division : ImatTypes
{
    public double getValue(double a, double b)
    {
        return a/b;
    }
}   



public class Multiplication : ImatTypes
{
    public double getValue(double a, double b)
    {
        return a*b;
    }
}     




public class Logaritme : ImatTypes
{
    public double getValue(double a, double b)
    {
        return Math.Log(a, b);
    }
}    