public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int i = str.IndexOf(delimiter);
        return str[(i+delimiter.Length)..];
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type

    public static string SubstringBetween(this string str, string li, string ri){
        int left = str.IndexOf(li);
        int right = str.IndexOf(ri);
        return str[(left+li.Length)..right];
    }

    
    // TODO: define the 'Message()' extension method on the `string` type

    public static string Message(this string str) => str.SubstringAfter(":").Trim();


    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}