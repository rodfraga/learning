public class PascalTriangle {
    public IList<IList<int>> Generate(int numRows) {
        var levels = new int[numRows][];
        
        for(int index = 0; index < numRows; index++) {
            var current = new int[index + 1];
            current[0] = 1;
            
            if(index > 0)
            {
                var prev = levels[index - 1];
                if(prev != null) {
                    for(int i = 1; i< current.Length - 1; i++) {
                        var l = prev[i - 1];
                        var r = prev[i];
                        current[i] = l + r;
                    }
                }
                
            }
            
            current[^1] = 1;
            levels[index] = current;
        }
        
        return levels;
    }
}
