using AwesomeAssertions;

namespace WordWrap;

public class WordWrapTest
{
    [Fact]
    public void Cuando_IngresoUnaPalabraVaciaCon1Columna_Debe_RegresarLaPalabraVacia()
    {
        var result = Wrap("", 1);

        result.Should().Be("");
    }
    
    [Fact]
    public void Cuando_IngresoThisCon01Columnas_Debe_RegresarThis()
    {
        var result = Wrap("this", 10);

        result.Should().Be("this");
    }  

    private static string Wrap(string text, int col)
    {
        return text;
    }
}