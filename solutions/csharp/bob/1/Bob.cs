public static class Bob
{
    public static string Response(string statement)
    {
        string statementTrimmed = statement.Trim();
        bool containsLetters = statementTrimmed.Any(char.IsLetter);
        bool isUpper = !string.IsNullOrEmpty(statementTrimmed) && !statementTrimmed.Any(char.IsLower) && containsLetters;

        if (isUpper && statementTrimmed.EndsWith("?"))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (statementTrimmed.EndsWith("?"))
        {
            return "Sure.";
        } 
            else if (isUpper)
        {
            return "Whoa, chill out!";
        }else if (string.IsNullOrEmpty(statementTrimmed))
        {
            return "Fine. Be that way!";
        }else{
            return "Whatever.";
        }

    }
}