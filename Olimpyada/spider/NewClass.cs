using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spider
{
    public class Movement
    {
        public static double Rect(int[] a, int[] b, int[] c)
        {
            return Math.Sqrt(Math.Pow(a[1] - a[2], 2) + Math.Pow(Math.Abs(b[1] - b[2]) + Math.Abs(c[1] - c[2]), 2));
        }
        
        public static double Otherside(int[] a, int[] b, int[] c)
        {
            return Math.Sqrt(Math.Pow(a[1] - a[2], 2) + Math.Pow((b[0] - b[1]) + (b[0] - b[2]) + (c[0] - c[1]) + (c[0] - c[2]), 2));
        }
        
        public static double Rev(int[] a, int[] b, int[] c)
        {
            return Math.Sqrt(Math.Pow(a[1] - a[2], 2) + Math.Pow((b[1] + b[2]) + (c[1] + c[2]), 2));
        }

        public static double MotionTracking(int[] a, int[] b, int[] c)
        {
            if (b[2] == b[1] || a[2] == 0 || a[2] == a[0])
                return Rect(c, a, b);
                
            else if (c[2] == 0 || c[2] == c[0])
                return Rect(a, b, c);
                
            else
            {
                if (a[1] + a[2] > a[0] || b[1] + b[2] > b[0])
                    return Otherside(c, b, a);
                else
                    return Rev(c, b, a);
            }
        }
    }
}