
public class ReverseInteger {
    public int Solve(int x) {
        
        long reversed = 0;
        var positive = x >= 0;
        
        long copy = (positive) ? x : x * -1;
        
        while (copy > 0) {
            reversed = (reversed * 10) + (copy % 10);
            copy = copy / 10;
        }
        
        reversed = (positive) ? reversed : reversed * -1;
        
        if(reversed > int.MaxValue || reversed < int.MinValue) {
            return 0;
        }
        
        // result
        return (int)reversed;
    }
    
}
