public static class LogAnalysis 
{
   public static string SubstringAfter(this string str, string str2) //assumption str is a input string and str2 is a string we need to search
   {
      int indexofstr2 = str.IndexOf(str2) + str2.Length; //search location of the letter, because when we search the location number is the first char of the word so we have to + the length of the letter.
      return str = str.Substring(indexofstr2,str.Length - indexofstr2);
   }
   public static string SubstringBetween(this string str, string str2, string str3) //like above str is a input string and str 2, str3 
   {
       int indexoffirst = str.IndexOf(str2) + str2.Length;
       int indexoflast = str.IndexOf(str3);
        return str = str.Substring(indexoffirst,indexoflast - indexoffirst);
   }
    public static string Message(this string str)//Task 3
    {
        string[] parts = str.Split(": ");
        return parts[1];
    }
    public static string LogLevel(this string str)//Task 4
    {
        int indexoffirst = str.IndexOf("[") + 1;
        int indexoflast = str.IndexOf("]");
        return str = str.Substring(indexoffirst,indexoflast - indexoffirst);
    }
}