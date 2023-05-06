using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Aggregation_and_Containment
{
    internal class Student
    {
        string _firstName;
        string _lastName;
        int _csiGrade;
        int _genEdGrade;

        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            CsiGrade = csiGrade;
            GenEdGrade = genEdGrade;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public int GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} - {_csiGrade} - {_genEdGrade}";
        }
    }
}
