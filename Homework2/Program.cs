using System;
using System.Collections.Generic;

namespace Homework2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Person = new School();
            Person.AddPerson("tornike");
            Person.SetPoint("tornike", 7);
            Person.GetPersonPoint("tornike");
        }
    }
}
