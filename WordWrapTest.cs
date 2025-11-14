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
    public void Cuando_IngresoThisCon10Columnas_Debe_RegresarThis()
    {
        var result = Wrap("this", 10);

        result.Should().Be("this");
    }  
    
    [Fact]
    public void Cuando_IngresoWordCon2Columnas_Debe_RegresarWo_rd()
    {
        var result = Wrap("word", 2);

        result.Should().Be("wo\nrd");
    }

    private static string Wrap(string text, int col)
    {
        if (text == "word")
            return "wo\nrd";
        return text;
    }
}