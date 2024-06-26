using DefaultNamespace;
using DefaultNamespace.MatCalculations;

namespace TestProject1;

public class Tests
{
    
   
    
    [TestCase]
    public void Add()
    {
        MatTypes addition = new MatTypes(new Addition());
        Assert.AreEqual(31, addition.getValue(20, 11));
    }
    
    [TestCase]
    public void Sub()
    {
        MatTypes substraction = new MatTypes(new Substraction());
        Assert.AreEqual(9, substraction.getValue(20, 11));
        
    }
    
    [TestCase]
    public void Multiplication()
    {
        MatTypes multiplication = new MatTypes(new Multiplication());
        Assert.AreEqual(20, multiplication.getValue(2, 10));
        
    }
    
    [TestCase]
    public void Divide()
    {
        MatTypes division = new MatTypes(new Division());
        Assert.AreEqual(10, division.getValue(20, 2));
        
    }
    
    [TestCase]
    public void Log()
    {
        MatTypes logaritme = new MatTypes(new Logaritme());
        Assert.AreEqual(2, logaritme.getValue(100, 10));
        
    }

}