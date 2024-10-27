
using ClassLibrary;

namespace PNIPU_C__LAB_10
{
    internal class AgeComparer : IComparer<IInit>
    {
        public int Compare(IInit? x, IInit? y)
        {
            return ((Person)x).Age.CompareTo(((Person)y).Age);
        }
    }
}
