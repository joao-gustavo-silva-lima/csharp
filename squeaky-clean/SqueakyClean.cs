using System.Text;

public static class Identifier
{
    private static string GreekAlphabet = "αβγδεζηθικλμνξοπρστυφχψω";
    public static string Clean(string identifier)
    {
        if(string.IsNullOrEmpty(identifier)) return string.Empty;

        var buffer = new StringBuilder();

        for( int i = 0 ; i < identifier.Length ; i++ )
        {
            char c = identifier[i];

            if(char.IsLetter(c) && !GreekAlphabet.Contains(c))
            {
                buffer.Append(c); continue;
            }
            else if(c == ' ')
            {
                buffer.Append('_'); 
            }
            else if(c == '\0')
            {
                buffer.Append("CTRL");
            }
            else if(c == '-' && i < identifier.Length - 1)
            {
                c = identifier[++i];
                buffer.Append(char.ToUpperInvariant(c)); 
            }
        }

        return buffer.ToString();
    }
}
