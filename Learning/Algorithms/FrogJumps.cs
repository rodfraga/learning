namespace Learning.Algorithms
{
    public class FrogJumps
    {
        public int Solution()
        {
            int distance = y - x;
            int jumps;

            if (distance % d == 0)
                jumps = distance / d;
            else
                jumps = (distance + d) / d;


            return jumps;
        }

        public FrogJumps(int x, int y, int d)
        {
            this.x = x;
            this.y = y;
            this.d = d;
        }

        readonly int x;
        readonly int y;
        readonly int d;
    }
}
