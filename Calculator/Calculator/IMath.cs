namespace Calculator
{
    public interface IMath
    {
        int A { get; }
        int B { get; }

        int intDivision(int a, int b);
        int intMinus(int a, int b);
        int intMultiply(int a, int b);
        int intPlus(int a, int b);
    }
}