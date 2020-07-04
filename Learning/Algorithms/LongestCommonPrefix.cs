
public class LongestCommonPrefix {
    public string Solve(string[] strs) {
        
       for (int i = 0; i < (strs.FirstOrDefault()?.Length ?? 0); i++){
            var match = strs[0][i];
            foreach (var s in strs.Skip(1)){
                if (s.Length == i || s[i] != match){
                    return strs[0][0..(i)];
                }
            }
        }
        
        return strs.FirstOrDefault() ?? "";
    }
}
