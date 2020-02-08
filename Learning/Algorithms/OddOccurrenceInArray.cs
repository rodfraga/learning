namespace Learning.Algorithms
{
    public class OddOccurrenceInArray
    {
        public int Solution()
        {
            var result = 0;

            //  validation
            if (elements == null || elements.Length == 0)
                return result;

            // xor do the trick (x xor x) = 0
            foreach (var item in elements)
                result ^= item;

            return result;
        }

        public OddOccurrenceInArray(int[] elements)
        {
            this.elements = elements;
        }

        readonly int[] elements;

    }
}
