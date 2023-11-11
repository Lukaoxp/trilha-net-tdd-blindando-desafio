using CalculadoraTDD;
namespace CalculadoraTDDTestes;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "02/02/2020";
        Calculadora calc = new Calculadora(data);
        return calc;
    }
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int val1, int val2, int val3)
    {
        Calculadora calc = construirClasse();
        int resultado = calc.Soma(val1, val2);

        Assert.Equal(val3, resultado);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(5, 4, 1)]
    public void TesteSubtrair(int val1, int val2, int val3)
    {
        Calculadora calc = construirClasse();
        int resultado = calc.Subtracao(val1, val2);

        Assert.Equal(val3, resultado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int val3)
    {
        Calculadora calc = construirClasse();
        int resultado = calc.Multiplicacao(val1, val2);

        Assert.Equal(val3, resultado);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClasse();
        Assert.Throws<DivideByZeroException>(() => calc.Divisao(3, 0));
    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(20, 5, 4)]
    public void TesteDividir(int val1, int val2, int val3)
    {
        Calculadora calc = construirClasse();
        int resultado = calc.Divisao(val1, val2);
        Assert.Equal(val3, resultado);
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.Soma(1, 2);
        calc.Soma(2, 8);
        calc.Soma(3, 5);
        calc.Soma(4, 1);

        var lista = calc.Historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}
