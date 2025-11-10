static class LogLine
{
    public static string Message(string logLine)
    {
        string[] tach = logLine.Split(':');
        if (tach.Length >1)
        {
            return tach[1].Trim();
        }
        return logLine.Trim();
        
    }

    public static string LogLevel(string logLine)
    {
        int startnumb = logLine.IndexOf('[')+1;
        int endnumb = logLine.IndexOf(']');
        if (startnumb >= 0){
           return logLine = logLine.Substring(startnumb,endnumb-startnumb).ToLower();
        }
        return "";
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string loglevel = LogLevel(logLine);
        return $"{message} ({loglevel})";
    }
}
