using System;
using System.Collections;

namespace Tests
{
    public class Car : IComparable<Car>
    {
        // Beginning of nested classes.
        // Nested class to do ascending sort on year property.
        private class sortYearAscendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;

                if (c1.year > c2.year)
                    return 1;

                if (c1.year < c2.year)
                    return -1;

                else
                    return 0;
            }
        }

        // Nested class to do descending sort on year property.
        private class sortYearDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;

                if (c1.year < c2.year)
                    return 1;

                if (c1.year > c2.year)
                    return -1;

                else
                    return 0;
            }
        }

        // Nested class to do descending sort on make property.
        private class sortMakeDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;
                return String.Compare(c2.make, c1.make);
            }
        }
        // End of nested classes.
        private int year;
        private string make;

        public Car(string Make, int Year)
        {
            make = Make;
            year = Year;
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        // Method to return IComparer object for sort helper.
        public static IComparer sortYearAscending()
        {
            return (IComparer)new sortYearAscendingHelper();
        }
        // Method to return IComparer object for sort helper.
        public static IComparer sortYearDescending()
        {
            return (IComparer)new sortYearDescendingHelper();
        }
        // Method to return IComparer object for sort helper.
        public static IComparer sortMakeDescending()
        {
            return (IComparer)new sortMakeDescendingHelper();
        }

        public int CompareTo(Car other)
        {
            int returnValue = 0;
            if (this.year == other.year)
                returnValue = 0;
            if (this.year < other.year)
                returnValue = -1;
            if (this.year > other.year)
                returnValue = 1;

            return returnValue;
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                var o = obj as Car;
                return (year == o.year);
            }
        }
    }
}