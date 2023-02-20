using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class LabClass
    {
        /// <summary>
        /// This will automotically create 
        /// a field that is a list of students 
        /// called labclass 
        /// </summary>
        public List<Student> labClass
         { get; private set;}

        public LabClass()
        {
            this.labClass = new List<Student>();
        }

        /// <summary>
        /// 
        /// </summary>
        public void addStudent(Student student)
        {
            labClass.Add(student);
        }




    } // end of class
} // end of namespace 
