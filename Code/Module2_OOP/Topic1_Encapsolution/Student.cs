using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Topic1_Encapsolution
{
    internal class Student
    {
        private string id;
        private string name;
        private DateTime dob;
        private bool gender;

        public Student()
        {
        }

        public Student(string id, string name, DateTime dob, bool gender)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.gender = gender;
        }

        //Encapsolation fields -> Properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public bool Gender { get => gender; set => gender = value; }

        public override string? ToString()
        {
            return $"ID: {id}, Name: {name}, Dob: {dob:dd/MM/yyyy}, Gender: {(gender == true ? "Male" : "Female")}";
        }
    }


}
