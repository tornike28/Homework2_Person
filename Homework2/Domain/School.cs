using System;
using System.Collections.Generic;


namespace Homework2
{
    public class School : ISchool
    {
        public IDictionary<string, int?> Person = new Dictionary<string, int?>();

        public void AddPerson(string name)
        {
            if (string.IsNullOrEmpty(name.Trim()))
            {
                
               CommandExecution.Fail(ErrorCode.IncorrectName);
                
            }
            else if (Person.ContainsKey(name))
            {
                CommandExecution.Fail(ErrorCode.UserMustBeUnique);
            }
            else
            {
                Person.Add(name, null);
            }
        }

        public void GetPersonPoint(string name)
        {
            if (Person.ContainsKey(name))
            {
                Console.WriteLine($"{name}{" point is "}{Person[name]}");
            }
            else
            {
                CommandExecution.Fail(ErrorCode.UserNotFound);
            }
        }

        public void RemovePerson(string name)
        {
            if (Person.ContainsKey(name))
            {
                Person.Remove(name);
            }
            else
            {
                CommandExecution.Fail(ErrorCode.UserNotFound);
            }
        }

        public void SetPoint(string name, int point)
        {
            if (!Person.ContainsKey(name))
            {
                CommandExecution.Fail(ErrorCode.UserNotFound);
            }
            else if (!(point >= 0 && point <= 10))
            {
                CommandExecution.Fail(ErrorCode.PointIsNotValid);
            }
            else
            {
                Person[name] = point;
            }
        }
    }

}

