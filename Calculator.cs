public class Calculator
{
    public int Add(int left, int right) => left + right;

    public int Subtract(int left, int right) => left - right;

    public int Multiply(int left, int right) => left * right;

    public decimal Divide(decimal left, decimal right)
    {
        if (right == 0)
        {
            throw new DivideByZeroException("No se puede dividir entre cero.");
        }

        return left / right;
    }
}
