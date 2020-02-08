using System;
namespace Learning.Algorithms
{
    public class QuickSort
    {
        private readonly int[] array = new int[20];
        private int len;

        public void Sort()
        {
            len = array.Length;
            Sort(0, len - 1);
        }

        public void Sort(int left, int right)
        {
            int pivot, leftend, rightend;

            leftend = left;
            rightend = right;
            pivot = array[left];

            while (left < right)
            {
                while ((array[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }

                while ((array[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }

            array[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;

            if (left < pivot)
            {
                Sort(left, pivot - 1);
            }

            if (right > pivot)
            {
                Sort(pivot + 1, right);
            }
        }
    }
}
