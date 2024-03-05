namespace MathApi.Calculator.UnitTests;

using MathApi.Calculator;
using NUnit.Framework;

public class CalculatorTests
{
    [Test]
    public void Calculate_Add_ReturnsSum()
    {
        // Arrange
        const int x = 5;
        const int y = 10;
        const string operation = "Add";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.EqualTo(15));
    }
    
    [Test]
    public void Calculate_Subtract_ReturnsDifference()
    {
        // Arrange
        const int x = 10;
        const int y = 5;
        const string operation = "Subtract";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    [Test]
    public void Calculate_Multiply_ReturnsProduct()
    {
        // Arrange
        const int x = 5;
        const int y = 10;
        const string operation = "Multiply";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.EqualTo(50));
    }
    
    [Test]
    public void Calculate_Divide_ReturnsQuotient()
    {
        // Arrange
        const int x = 10;
        const int y = 5;
        const string operation = "Divide";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Calculate_Square_ReturnsSquare()
    {
        // Arrange
        const int x = 5;
        const string operation = "Square";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(25));
    }
    
    [Test]
    public void Calculate_Cube_ReturnsCube()
    {
        // Arrange
        const int x = 5;
        const string operation = "Cube";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(125));
    }
    
    [Test]
    public void Calculate_Sin_ReturnsSine()
    {
        // Arrange
        const int x = 0;
        const string operation = "Sin";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Cos_ReturnsCosine()
    {
        // Arrange
        const int x = 0;
        const string operation = "Cos";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void Calculate_Tan_ReturnsTangent()
    {
        // Arrange
        const int x = 0;
        const string operation = "Tan";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Asin_ReturnsArcSine()
    {
        // Arrange
        const int x = 0;
        const string operation = "Asin";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Acos_ReturnsArcCosine()
    {
        // Arrange
        const int x = 1;
        const string operation = "Acos";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Atan_ReturnsArcTangent()
    {
        // Arrange
        const int x = 0;
        const string operation = "Atan";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Sinh_ReturnsHyperbolicSine()
    {
        // Arrange
        const int x = 0;
        const string operation = "Sinh";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Cosh_ReturnsHyperbolicCosine()
    {
        // Arrange
        const int x = 0;
        const string operation = "Cosh";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void Calculate_Tanh_ReturnsHyperbolicTangent()
    {
        // Arrange
        const int x = 0;
        const string operation = "Tanh";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Asinh_ReturnsHyperbolicArcSine()
    {
        // Arrange
        const int x = 0;
        const string operation = "Asinh";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Acosh_ReturnsHyperbolicArcCosine()
    {
        // Arrange
        const int x = 1;
        const string operation = "Acosh";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Atanh_ReturnsHyperbolicArcTangent()
    {
        // Arrange
        const int x = 0;
        const string operation = "Atanh";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Ln_ReturnsNaturalLogarithm()
    {
        // Arrange
        const int x = 1;
        const string operation = "Ln";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Log10_ReturnsBase10Logarithm()
    {
        // Arrange
        const int x = 1;
        const string operation = "Log10";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate_Exp_ReturnsExponential()
    {
        // Arrange
        const int x = 0;
        const string operation = "Exp";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void Calculate_Sqrt_ReturnsSquareRoot()
    {
        // Arrange
        const int x = 4;
        const string operation = "Sqrt";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Calculate_Pow_ReturnsPower()
    {
        // Arrange
        const int x = 2;
        const int y = 3;
        const string operation = "Pow";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.EqualTo(8));
    }
    
    [Test]
    public void Calculate_Root_ReturnsRoot()
    {
        // Arrange
        const int x = 8;
        const int y = 3;
        const string operation = "Root";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Calculate_Floor_ReturnsFloor()
    {
        // Arrange
        const float x = 5.5f;
        const string operation = "Floor";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    [Test]
    public void Calculate_Ceiling_ReturnsCeiling()
    {
        // Arrange
        const float x = 5.5f;
        const string operation = "Ceiling";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(6));
    }
    
    [Test]
    public void Calculate_Truncate_ReturnsTruncate()
    {
        // Arrange
        const float x = 5.5f;
        const string operation = "Truncate";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    [Test]
    public void Calculate_Max_ReturnsMax()
    {
        // Arrange
        const int x = 5;
        const int y = 10;
        const string operation = "Max";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    
    [Test]
    public void Calculate_Min_ReturnsMin()
    {
        // Arrange
        const int x = 5;
        const int y = 10;
        const string operation = "Min";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    [Test]
    public void Calculate_Factorial_ReturnsFactorial()
    {
        // Arrange
        const int x = 5;
        const string operation = "Factorial";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    
    [Test]
    public void Calculate_Percentage_ReturnsPercentage()
    {
        // Arrange
        const int x = 50;
        const int y = 10;
        const string operation = "Percentage";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    [Test]
    public void Calculate_Modulus_ReturnsModulus()
    {
        // Arrange
        const int x = 10;
        const int y = 3;
        const string operation = "Modulus";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void Calculate_Absolute_ReturnsAbsolute()
    {
        // Arrange
        const int x = -5;
        const string operation = "Absolute";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    [Test]
    public void Calculate_Random_ReturnsRandom()
    {
        // Arrange
        const int x = 1;
        const int y = 10;
        const string operation = "Random";
        
        // Act
        var result = Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(result, Is.InRange(x, y));
    }
    
    [Test]
    public void Calculate_Round_ReturnsRounded()
    {
        // Arrange
        const float x = 5.5f;
        const string operation = "Round";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(6));
    }
    
    [Test]
    public void Calculate_RadiusDiameter_ReturnsRadius()
    {
        // Arrange
        const float x = 10;
        const string operation = "RadiusDiameter";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    [Test]
    public void Calculate_RadiusCircumference_ReturnsRadius()
    {
        // Arrange
        const float x = 10;
        const string operation = "RadiusCircumference";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo(10 / (2 * (float)Math.PI)));
    }
    
    [Test]
    public void Calculate_RadiusArea_ReturnsRadius()
    {
        // Arrange
        const float x = 10;
        const string operation = "RadiusArea";
        
        // Act
        var result = Calculator.Calculate(operation, x, 0);
        
        // Assert
        Assert.That(result, Is.EqualTo((float)Math.Sqrt(10 / (float)Math.PI)));
    }
    
    [Test]
    public void Calculate_InvalidOperation_ThrowsArgumentException()
    {
        // Arrange
        const int x = 5;
        const int y = 10;
        const string operation = "Invalid";
        
        // Act
        TestDelegate act = () => Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(act, Throws.ArgumentException);
    }
    
    [Test]
    public void Calculate_DivideByZero_ThrowsInvalidOperationException()
    {
        // Arrange
        const int x = 5;
        const int y = 0;
        const string operation = "Divide";
        
        // Act
        TestDelegate act = () => Calculator.Calculate(operation, x, y);
        
        // Assert
        Assert.That(act, Throws.InvalidOperationException);
    }
}