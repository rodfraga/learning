namespace Learning.Algorithms
{
    public class SumToZero
    {
        public void FindSets(int n)
        {
            if (n == 0)
                return;

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
            
        }
    }
}
