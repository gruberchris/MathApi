namespace MathApi.Calculator;

public enum MathOperation
{
    Add,
    Subtract,
    Multiply,
    Divide,
    Square,
    Cube,
    Sin,
    Cos,
    Tan,
    Asin,
    Acos,
    Atan,
    Sinh,
    Cosh,
    Tanh,
    Asinh,
    Acosh,
    Atanh,
    Ln,
    Log10,
    Exp,
    Sqrt,
    Pow,
    Root,
    Floor,
    Ceiling,
    Truncate,
    Max,
    Min,
    Factorial,
    Percentage,
    Modulus,
    Absolute,
    Random,
    Round,
    RadiusDiameter,
    RadiusCircumference,
    RadiusArea
}

public static class Calculator
{
    public static float Calculate(string operation, float x, float y) =>
        Calculate(Enum.Parse<MathOperation>(operation, true), x, y);

    private static float Calculate(MathOperation operation, float x, float y) =>
        operation switch
        {
            MathOperation.Add => x + y,
            MathOperation.Subtract => x - y,
            MathOperation.Multiply => x * y,
            MathOperation.Divide => Divide(x, y),
            MathOperation.Square => x * x,
            MathOperation.Cube => x * x * x,
            MathOperation.Sin => (float)Math.Sin(x),
            MathOperation.Cos => (float)Math.Cos(x),
            MathOperation.Tan => (float)Math.Tan(x),
            MathOperation.Asin => (float)Math.Asin(x),
            MathOperation.Acos => (float)Math.Acos(x),
            MathOperation.Atan => (float)Math.Atan(x),
            MathOperation.Sinh => (float)Math.Sinh(x),
            MathOperation.Cosh => (float)Math.Cosh(x),
            MathOperation.Tanh => (float)Math.Tanh(x),
            MathOperation.Asinh => (float)Math.Asinh(x),
            MathOperation.Acosh => (float)Math.Acosh(x),
            MathOperation.Atanh => (float)Math.Atanh(x),
            MathOperation.Ln => (float)Math.Log(x),
            MathOperation.Log10 => (float)Math.Log10(x),
            MathOperation.Exp => (float)Math.Exp(x),
            MathOperation.Sqrt => (float)Math.Sqrt(x),
            MathOperation.Pow => (float)Math.Pow(x, y),
            MathOperation.Root => CalculateRoot(x, y),
            MathOperation.Floor => (float)Math.Floor(x),
            MathOperation.Ceiling => (float)Math.Ceiling(x),
            MathOperation.Truncate => (float)Math.Truncate(x),
            MathOperation.Max => Math.Max(x, y),
            MathOperation.Min => Math.Min(x, y),
            MathOperation.Factorial => CalculateFactorial(x),
            MathOperation.Percentage => x * y / 100,
            MathOperation.Modulus => x % y,
            MathOperation.Absolute => Math.Abs(x),
            MathOperation.Random => Random.Shared.Next((int)x, (int)y),
            MathOperation.Round => (float)Math.Round(x),
            MathOperation.RadiusDiameter => x / 2,
            MathOperation.RadiusCircumference => x / (2 * (float)Math.PI),
            MathOperation.RadiusArea => (float)Math.Sqrt(x / (float)Math.PI),
            _ => throw new InvalidOperationException("Invalid operation")
        };
    
    private static float Divide(float x, float y) =>
        y == 0 ? throw new InvalidOperationException("Invalid operation") : x / y;
    
    private static float CalculateRoot(float x, float y) =>
        y == 0 ? throw new InvalidOperationException("Invalid operation") : (float)Math.Pow(x, 1 / y);
    
    private static float CalculateFactorial(float x) =>
        x switch
        {
            0 => 1,
            < 0 => throw new InvalidOperationException("Invalid operation"),
            _ => Enumerable.Range(1, (int)x).Aggregate((a, b) => a * b)
        };
}