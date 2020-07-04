public class SqrtAlgorithm {
    public int Solve(int x) {
        
        if(x == 0)
            return 0;
        
        decimal r = x;
        decimal t = 0;
        
        while(t != r) {
            t = r;
            r = 0.5m * ((x / r) + r);
        }
        
        return (int)Math.Truncate(r);
    }
}
