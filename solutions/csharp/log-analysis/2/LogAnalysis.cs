public static class LogAnalysis 
{
   public static string SubstringAfter(this string str, string str2)
   {
      return str.Split(str2)[1];
   }
   public static string SubstringBetween(this string str, string str2, string str3)
   {
       return str.Split(str2)[1].Split(str3)[0];
   }
   public static string Message(this string str)
   {
       return str.SubstringAfter(": ");
   }
   public static string LogLevel(this string str)
   {
       return str.SubstringBetween("[","]");
   }
}