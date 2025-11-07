static class LogLine
{
    public static string Message(string logLine)
    {
        int logLinespace = logLine.IndexOf(" ")+1;
        var logLinenew = logLine.Substring(logLinespace,logLine.Length - logLinespace);
        var logLinedash = logLinenew.IndexOf('\t');
        if (logLinedash != -1)
        {
            var logLinefirst = logLinenew.Substring(logLinedash+1);
            var logLinelast = logLinefirst.IndexOf("  ");
            var logLinenew01 = logLinefirst.Substring(0,logLinelast);
            return logLinenew01;
        }
        else
        {
            return logLinenew;
        }
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.Contains("ERROR"))
        {
        return logLine = "error";
        }
        else if (logLine.Contains("WARNING"))
        {
            return logLine = "warning";
        }
        else
        {
            return logLine = "info";
        }
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string[] mang = logLine.Split(' ',2);
        string mang1 = mang[0];
        string mang2 = mang[1];
        char [] chartotrym1 = {'[', ']', ':'};
        string newmang1 = mang1.Trim(chartotrym1).ToLower();
        if (mang2.Contains("\t"))
        {
            mang2 = mang2.Replace("\t"," ");
            mang2 = mang2.TrimStart();
            string mang2moi = mang2.Substring(0,mang2.LastIndexOf(" ")).TrimEnd();
            return $"{mang2moi} ({newmang1})";
        }
        else
        {
        return $"{mang2} ({newmang1})";
        }
    }
}
