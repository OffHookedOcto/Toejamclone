using System;

namespace Demo
{
    public class Name
    {
        public static int SIZE { get; internal set; }

        public static explicit operator int(Name v)
        {
            throw new NotImplementedException();
        }
    }
}