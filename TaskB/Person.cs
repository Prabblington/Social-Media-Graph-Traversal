using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_TaskB_SocialNetwork
{
    class Person : IComparable
    {
        private string name;

        public Person(string n)
        {
            name = n;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CompareTo(Object obj)
        {
            Person other = (Person)obj;
            return Name.CompareTo(other.Name);
        }
        int IComparable.CompareTo(Object obj)
        {
            Person other = (Person)obj;
            return Name.CompareTo(other.Name);
        }
    }
}
