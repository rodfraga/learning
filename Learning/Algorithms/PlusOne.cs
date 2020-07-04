public class PlusOne {
    public int[] Solve(int[] digits) {
        
        int n = digits.Length;
        int[] res = new int[n + 1];
        for(int i = n - 1; i >= 0; i--){
          if(digits[i] < 9){
              digits[i]++;
              return digits;
          } else {
              digits[i] = 0;
          }
        }
        res[0] = 1;
        return res;
    }
}
