using System.Collections.Generic;

namespace HackerRank_CompareTriplets
{
    public class Result
    {

        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alicePoints = 0;
            int bobPoints = 0;

            List<int> result = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                int firstValue = a[i];
                int secondValue = b[i];

                if (firstValue > secondValue)
                {
                    alicePoints++;
                }
                else if(firstValue < secondValue)
                {
                    bobPoints++;
                }

            }

            result.Add(alicePoints);
            result.Add(bobPoints);

            return result;
        }

    }
}
