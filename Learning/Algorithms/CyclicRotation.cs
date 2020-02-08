namespace Learning.Algorithms
{
    public class CyclicRotation
    {
        public int[] Solution(int[] values, int times)
        {
            if (values == null || values.Length == 0)
                return new int[] { };

            for (int cycle = 0; cycle < times; cycle++)
            {
                var last = values[^1];
                //var last = values[values.Length - 1];

                for (int n = values.Length - 1; n >= 0; n--)
                    values[n] = values[n - 1];

                values[0] = last;
            }

            return values;
        }

    }
}
