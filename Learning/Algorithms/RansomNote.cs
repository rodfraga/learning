

// Given an arbitrary ransom note string and 
// another string containing letters from all the magazines, 
// write a function that will return true if the ransom note 
// can be constructed from the magazines ; otherwise, it will 
// return false.

// Each letter in the magazine string can only be used once 
// in your ransom note.
public class RansomNote {

    public bool canConstruct(string ransomNote, string magazine) {
        // 
        if(string.IsNullOrEmpty(ransomNote) || string.IsNullOrEmpty(magazine))
            return false;

        var left = new char[26];
        var right = new char[26];

        foreach(var c in ransomNote)
            left[c-'a']++;

        foreach(var c in magazine)
            right[c-'a']++;

        for(int i = 0; i < 26; i++)
            if(left[i] > right[i]
                return false;

        return true; 
    }

}