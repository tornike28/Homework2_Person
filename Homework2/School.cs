using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class School : ISchool
    {
        public Dictionary<string, int> Person = new Dictionary<string, int>();

        public void AddPerson(string name, int point = 0)
        {
            Person.Add(name, point);
        }

        public void GetPersonPoint(string name)
        {
            Console.WriteLine(Person[name]);
        }

        public void RemovePerson(string name)
        {
            Person.Remove(name);
        }

        public void SetPoint(string name, int point)
        {
            Person[name] = point;
        }
    }
}

