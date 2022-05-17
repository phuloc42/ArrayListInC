using System;
using System.Collections;

namespace ArrayListInC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrPerson = new ArrayList();

            arrPerson.Add(new Person("Phu Loc", 22));
            arrPerson.Add(new Person("Van Thanh", 18));
            arrPerson.Add(new Person("Phu Loc", 20));

            Console.WriteLine("Danh sach person ban dau la");
            foreach (Person person in arrPerson)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadLine();

            arrPerson.Sort(new SortPerson());

            Console.WriteLine();
            Console.WriteLine("Danh sach da sap xep:");
            foreach(Person person in arrPerson)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
    public class SortPerson : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;

            if(p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (p1.Age > p2.Age)
                {
                    return 1;
                }
                else if(p1.Age == p2.Age)
                {
                    return 0;
                }
                else return -1;
            }
        }
    }
}

