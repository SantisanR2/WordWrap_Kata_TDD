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

    private static string Wrap(string text, int col)
    {
        return "";
    }
}