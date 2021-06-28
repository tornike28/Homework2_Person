using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public interface ISchool
    {
        void AddPerson(string name, int point);

        void SetPoint(string name, int point);

        void RemovePerson(string name);

        void GetPersonPoint(string name);
    }
}
