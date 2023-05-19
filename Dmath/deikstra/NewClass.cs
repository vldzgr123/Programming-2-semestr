using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deikstra
{
    public class Ribr
    {
        public Peak peak1;
        public Peak peak2;
        public double weight;
    }
    public class Peak
    {
        public string name;
        public double weightMinimal=double.PositiveInfinity;
        public bool check=false;
    }
}