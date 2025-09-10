namespace CSharp.Intermediate.ExtensionMethod
{
    public static class ExtensionMethod
    {

        public static int WordCount(this string str)
        {
            return str.Split(' ').Length;
        }

        public static (int wordCount, int charCount) GetWordCount(this string str)
        {
            if(!string.IsNullOrEmpty(str))
            {

                int wordCount = str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                int charCount = str.Count(c => c != ' ');
                return (wordCount, charCount);
            }
            return (0, 0);
        }

        public static int GetNumberCount(this int num)
        {
            if(num != 0)
                return num.ToString().Length;
            return 0;
        }
    }
}
