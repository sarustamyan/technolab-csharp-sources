using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technolab.BigInt
{
    public class BigInt
    {
        public List<int> Number;

        public BigInt(List<int> value)
        {
            Number = value.ToList();
        }

        public BigInt(int value)
        {
            throw new NotImplementedException();
        }

        public BigInt Add(BigInt value)
        {
            throw new NotImplementedException();
        }

        public string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
