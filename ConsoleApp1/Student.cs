using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Student
    {
        public Name name { get; private set; }
        
        // can use field that are other objects
        public StudentID id
        { get; private set; }
        
        // grade always starts at 0
        private double averageGrade = 0;

        /// <summary>
        /// Here i am using the student constructor to get the arguments needed for a name object.
        /// when writing the name class i do not have to worry about where paramaters will come from.
        /// I am just using them as placeholders.
        /// The student class provides the paramters that are the correct type. 
        /// </summary>
        /// <param name="first">The paramater needed for an name object</param>
        /// <param name="last"></param>
        /// <param name="studentid"></param>
        public Student(string first,string last,string studentid)
        {
            // see here i am providing the paramaters for this student object 
            name = new Name(first, last); 
            id = new StudentID(studentid);
        }


        public string getName()
        {
            return name.ToString();
        }


        /// <summary>
        /// A set method to access the names field propertys 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        public void setName(string first,string last)
        {
            name.First = first;
            name.Last = last;
        }




        /// <summary>
        /// Property for name field 
        /// </summary>
        public Name Name
        {
            get { return name; }
        }

        public StudentID ID
        {
            get { return id; }
        }


    } // end of class
} // end of namespace 
