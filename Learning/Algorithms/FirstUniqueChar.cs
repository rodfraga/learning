// Given a string, find the first non-repeating 
// character in it and return its index. 
// If it doesn't exist, return -1.

public class FirstUniqueChar
{

    public int Solution(string s) {
        // edge case
        if(string.IsNullOrEmpty(s))
            return -1;

        var res = new chat[26];
        // counts
        for(int i = 0; i < s.Length; i++)
            res[s[i]-'a']++;

        // get first non repeating
        for(int i = 0; i < s.Length; i++)
            if(res[s[i]-'a'] == 1) return i;

        // if not exists
        return -1;
    }

}
