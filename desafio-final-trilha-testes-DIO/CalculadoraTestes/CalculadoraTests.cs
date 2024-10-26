using Calculadora.Services;
using Xunit;

namespace Calculadora.Services
{
  public class CalculadoraTests
  {
    private readonly Calculadora _calc;

    public CalculadoraTests()
    {
      _calc = new Calculadora();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
      // Arrange
      float num1 = 5;
      float num2 = 10;

      // Act
      float resultado = _calc.Somar(num1, num2);

      // Assert
      Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10com10ERetornar20()
    {
      // Arrange
      float num1 = 10;
      float num2 = 10;

      // Act
      float resultado = _calc.Somar(num1, num2);

      // Assert
      Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveSubtrair10de15ERetornar5()
    {
      // Arrange
      float num1 = 15;
      float num2 = 10;

      // Act
      float resultado = _calc.Subtrair(num1, num2);

      // Assert
      Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveMultiplicar3com4ERetornar12()
    {
      // Arrange
      float num1 = 3;
      float num2 = 4;

      // Act
      float resultado = _calc.Multiplicar(num1, num2);

      // Assert
      Assert.Equal(12, resultado);
    }

    [Fact]
    public void DeveDividir10por2ERetornar5()
    {
      // Arrange
      float num1 = 10;
      float num2 = 2;

      // Act
      float resultado = _calc.Dividir(num1, num2);

      // Assert
      Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveDividir10por0ERetornar0()
    {
      // Arrange
      float num1 = 10;
      float num2 = 0;

      // Act
      float resultado = _calc.Dividir(num1, num2);

      // Assert
      Assert.Equal(0, resultado);
    }

    [Fact]
    public void DeveRetornarHistoricoCorreto()
    {
      // Arrange
      _calc.Somar(5, 10);
      _calc.Subtrair(20, 5);
      _calc.Multiplicar(2, 3);
      _calc.Dividir(10, 2);
      _calc.Dividir(10, 0); // Testando divisão por zero

      // Act
      var historico = _calc.Historico();

      // Assert
      Assert.Contains("5 + 10 = 15", historico);
      Assert.Contains("20 - 5 = 15", historico);
      Assert.Contains("2 * 3 = 6", historico);
      Assert.Contains("10 / 2 = 5", historico);
      Assert.Contains("10 / 0 = Não é possível dividir por zero.", historico);
    }

    [Fact]
    public void HistoricoDeveTerQuatroEntradas()
    {
      // Arrange
      _calc.Somar(1, 1);
      _calc.Subtrair(3, 1);
      _calc.Multiplicar(2, 5);
      _calc.Dividir(10, 5);

      // Act
      var historico = _calc.Historico();

      // Assert
      Assert.Equal(4, historico.Count);
    }
  }
}
