static class LogLine
{
//Each log line is a string formatted as follows: `"[<LEVEL>]: <MESSAGE>"`.
    public static string Message(string logLine)
    {
        int Index = logLine.IndexOf(":") + 1;
        return logLine.Substring(Index).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int StartIndex = logLine.IndexOf("[")+1;
        int EndIndex = logLine.IndexOf("]") - 1;
        return logLine.Substring(StartIndex, EndIndex).ToLower();
    }
    
    public static string Reformat(string logLine)
    {
        String MessageOnly = Message(logLine);
        String ErrorOnly = LogLevel(logLine);
        return $"{MessageOnly} ({ErrorOnly})";
    }
    
    
}
