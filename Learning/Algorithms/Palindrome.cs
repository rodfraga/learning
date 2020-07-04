namespace Learning.Algorithms
{
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            // this regex has been added to make valid the LeetCode Valid Palindrome 
            // problem wich ignores punctuations and blank spaces
            Regex rgx = new Regex("[^a-zA-Z0-9]"); 
            word = rgx.Replace(word, "");
            
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                    return true;

                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                    return false;

                min++;
                max--;
            }
        }
    }
}
