static class LogLine
{
    public static string Message(string logLine){
        int i = logLine.IndexOf(":");
        return logLine[(i+1)..].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int li = logLine.IndexOf("[");
        int ri = logLine.IndexOf("]");
        return logLine[(li+1)..(ri)].ToLower();
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
