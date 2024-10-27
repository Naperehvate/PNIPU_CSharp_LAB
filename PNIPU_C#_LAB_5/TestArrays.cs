using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNIPU_C__LAB_5
{
    internal class TestArrays
    {
        public int[] OneDimArray { get; } = { 1, 2, 3, 4, 5 };

        public int[,] TwoDimArray { get; } =
        {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
        };

        public List<int[]> ToothedArray { get; } = new List<int[]>
        {
         new int[] { 1, 2, 3 },
         new int[] { 4, 5, 6 },
         new int[] { 7, 8, 9 }
        };
    }
}
