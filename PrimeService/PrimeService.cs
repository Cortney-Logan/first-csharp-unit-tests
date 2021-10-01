using System.Collections.Generic;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            List<int> factors = new List<int>();

            int counter = 1;

            while (counter <= candidate)
            {
                if (candidate % counter == 0)
                {
                    factors.Add(counter);
                }
                counter += 1;
            }

            if (factors.Count > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
