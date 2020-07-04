public class ReverseBits {
    public uint Solve(uint n) {
        uint ret = 0;
        // uint has 32 slots
        for (int i = 0; i < 32; i++)
        {
            //shift-left (100 now is 1000)
            ret <<= 1;
            // logical or to compound (100 | 101 ia 101)
            // and logical and to inverse (current n with 1) 
            ret |= (n & 1);
            // shift-right (1000 is now 100 cause is uint on int works differently) 
            n >>= 1;
        }
        
        return ret;
    }
}
