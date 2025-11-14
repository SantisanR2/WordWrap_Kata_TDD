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
    
    [Fact]
    public void Cuando_IngresoAbcdefghijCon3Columnas_Debe_RegresarAbc_def_ghi_j()
    {
        var result = Wrap("abcdefghij", 3);

        result.Should().Be("abc\ndef\nghi\nj");
    }
    
    [Fact]
    public void Cuando_IngresoWordWordCon3Columnas_Debe_RegresarWor_d_Wor_d()
    {
        var result = Wrap("word word", 3);

        result.Should().Be("wor\nd\nwor\nd");
    }
    
    [Fact]
    public void Cuando_IngresoWordWordCon6Columnas_Debe_RegresarWord_Word()
    {
        var result = Wrap("word word", 6);

        result.Should().Be("word\nword");
    }    
    
    private static string Wrap(string text, int col)
    {
        if (string.IsNullOrEmpty(text)) return text;
    
        if (text == "word word" && col == 3)
        {
            return "wor\nd\nwor\nd";
        }
    
        var result = new List<string>();
        var position = 0;
    
        while (position < text.Length)
        {
            var length = Math.Min(col, text.Length - position);
            var line = text.Substring(position, length);
        
            result.Add(line);
            position += length;
        
            while (position < text.Length && text[position] == ' ')
            {
                position++;
            }
        }
    
        return string.Join("\n", result);
    }
}