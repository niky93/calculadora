using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.Tests;

[TestClass]
public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [TestMethod]
    public void Add_ReturnsSum()
    {
        Assert.AreEqual(5, _calculator.Add(2, 3));
    }

    [TestMethod]
    public void Subtract_ReturnsDifference()
    {
        Assert.AreEqual(6, _calculator.Subtract(10, 4));
    }

    [TestMethod]
    public void Multiply_ReturnsProduct()
    {
        Assert.AreEqual(42, _calculator.Multiply(6, 7));
    }

    [TestMethod]
    public void Divide_ReturnsQuotient()
    {
        Assert.AreEqual(4m, _calculator.Divide(20, 5));
    }

    [TestMethod]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.ThrowsException<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }
}
