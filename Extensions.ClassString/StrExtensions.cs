namespace Extensions.ClassString
{
    public static class StringExtensions
    {
        public static int CountSpaces(this string s)
        {
            return s.Count(chr => chr == ' ');
        }
    }
}