namespace ACM.Common
{
    /// <summary>
    /// Inserts space before each capital letter in a string
    /// </summary>
    public static class StringHandler //extension methods must reside in a static class
    {
        public static string InsertSpaces(this string source) //now an extension method
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (var letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }

                    result += letter;
                }
            }

            result = result.Trim();
            return result;
        }
    }
}