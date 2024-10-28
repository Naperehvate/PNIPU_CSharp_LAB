using ClassLibrary;

namespace PNIPU_C__LAB_10
{
    internal class AgeComparer : IComparer<IInit>
    {
        //public int Compare(IInit? x, IInit? y)
        //{
        //    return ((Person)x).Age.CompareTo(((Person)y).Age);
        //}
        public int Compare(IInit? x, IInit? y)
        {
            if (x is Person  personX && y is Person personY)
            {
                return personX.Age.CompareTo(personY.Age);
            }
            if (x is AdditionalClass additionlClassX && y is AdditionalClass additionlClassY)
            {
                return additionlClassX.Age.CompareTo(additionlClassY.Age);
            }

            if (x is Person person && y is AdditionalClass additionalClass)
            {
                return person.Age.CompareTo(additionalClass.Age);
            }
            if (x is AdditionalClass additionalClass1 && y is Person person1)
            {
                return additionalClass1.Age.CompareTo(person1.Age);
            }
            return 0;
        }
    }
}