public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str,string delimiter)
    {
        int index = str.IndexOf(delimiter);
        return str.Substring(index + delimiter.Length);
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string str1,string str2)
    {
        int stringStart = str.IndexOf(str1)+ str1.Length;
        int stringEnd = str.IndexOf(str2);
        int stringLength = stringEnd - stringStart;
        return str.Substring(stringStart,stringLength);
    }  
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string logline)
    {
        int indexOfMessage = logline.IndexOf(":")+1;
        return logline.Substring(indexOfMessage).Trim();
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string logline)
    {
        int indexStart = logline.IndexOf("[")+1;
        int indexEnd = logline.IndexOf("]")-1;
        return logline.Substring(indexStart,indexEnd);
    }
}