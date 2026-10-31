namespace DotNetMastery.CommonUtils.DataSources
{
    public static class StringDataSource
    {
        // Simple string for basic reversal and iteration
        public static string GetSimpleString() => "DotNetMastery";

        // Palindrome strings for validation
        public static string GetPalindromeText() => "radar";
        public static string GetNonPalindromeText() => "developer";

        // Frequency and occurrence analysis
        public static string GetTargetString() => "programming";

        // Multi-word sentence for word reversal and tokenization
        public static string GetSentenceData() => "Welcome to CSharp Programming";

        // High frequency repeating characters
        public static string GetDuplicateString() => "indivisibility";

        // Anagram pairs for string matching problems
        public static (string Word1, string Word2) GetAnagramPair() => ("listen", "silent");
    }
}