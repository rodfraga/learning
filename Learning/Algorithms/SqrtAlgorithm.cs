public class SqrtAlgorithm {
    public int Solve(int x) {
        
        if(x == 0)
            return 0;
        
        decimal r = x;
        decimal t = 0;
        
        while(t != r) {
            t = r;
            // I tatooed the 0.5m instead of the 1 / 2 operation 
            // cause has a tradeoff of 46ms at runtime. (believe it or not!)
            r = 0.5m * ((x / r) + r);
        }
        
        return (int)Math.Truncate(r);
    }
}
