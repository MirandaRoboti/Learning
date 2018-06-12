using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops.Model
{
    public class UserInput
    {
        private List<int> numbers = new List<int>();

        public int MaxNumber(List<int> numbers)
        {
            var max = numbers.Max();
            return max;
        }
    }
}
