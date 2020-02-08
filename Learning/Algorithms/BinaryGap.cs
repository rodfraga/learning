using System;
using System.Linq;

namespace Learning.Algorithms
{
    public class BinaryGap
    {
        public int SolutionLinq(int value)
        {
            return Convert
            // convert to binary
            .ToString(value, 2)
            // remove leading and trailing 0s, as per requirement
            .Trim('0')
            // split the string by 1s
            .Split(new[] { '1' })
            // find the length of longest segment
            .Max(x => x.Length);
        }

        public int Solution(int value)
        {
            // casting it to uint while keeping the same binary value, like reinterpret_cast<unsigned int>
            //var unsigned = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);
            var unsigned = unchecked((uint)value);
            // flag used to ignore counting trailing 0's
            var pastTrailing0 = false;

            int max = 0, count = 0;
            while (unsigned > 0)
            {
                if ((unsigned & 1) == 1)
                {
                    if (count > max)
                        max = count;

                    count = 0;
                    pastTrailing0 = true;
                }
                else if (pastTrailing0)
                {
                    count++;
                }

                unsigned >>= 1;
            }

            return max;
        }
    }
}
