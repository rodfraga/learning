namespace Learning.Algorithms
{
    public class SumToZero
    {
        public static int[] FindSets(int n)
        {
            if (n == 0)
                return new int[0];

            int[] elements = new int[n];

            int size = n;

            for (int i = 0; i < size / 2; i++)
            {
                elements[i] = (i + 1) * -1;
            }

            if (n % 2 != 0)
            {
                for (int i = size / 2; i < size; i++)
                {
                    elements[i] = i - (size / 2);
                }
            }
            else
            {
                for (int i = size / 2; i < size; i++)
                {
                    elements[i] = i - ((size / 2) - 1);
                }
            }

            return elements;
        }
    }
}
