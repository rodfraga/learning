
public static bool WordBreak(string s, List<string> words)
{
  return WordBreak(s, words, new HashSet<int>(), 0);
}

public static bool WordBreak(string s, List<string> words, HashSet<int> visited, int index)
{
  if(!visited.Add(index))
    return false;
    
    if (index == s.Length)
      return true;
      
    var crop = s.Substring(index);
    foreach(var word in words) {
      if(sub.StartsWith(word) && WordBreak(s, words, visited, index + word.Length))
        return true;
    }
    
    return false;
}
