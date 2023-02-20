using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Represents a name to be used by a student object 
    /// </summary>
    class Name
    {

        private string first;
        private string middle;
        private string last;

        /// <summary>
        /// Constructor for Name obect that takes a first and last name
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        public Name(string first,string last)
        {
            this.first = first;
            this.last = last;
        }

        public Name(string first,string middle,string last)
        {
            this.first = first;
            this.middle = middle;
            this.last = last;
        }



        /// <summary>
        /// Returns a string rep of this students Name
        /// Concatanates values that are not null
        /// </summary>
        /// <returns></returns>
        public string getFullName()
        {
            string fullName = "";
            if(First!= string.Empty)
            {
                fullName += First;
            }
            if(Middle!= string.Empty)
            {
                fullName += " " + Middle;
            }
            if(Last!= string.Empty)
            {
                fullName += " " + Last;
            }
            return fullName;
        }


        /// <summary>
        /// Returns a string representation of this object 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string fullName = "";
            if (First != string.Empty)
            {
                fullName += First;
            }
            if (Middle != string.Empty)
            {
                fullName += " " + Middle;
            }
            if (Last != string.Empty)
            {
                fullName += " " + Last;
            }
            return fullName;
        }


        /// <summary>
        /// This and property below are for the names 
        /// </summary>
        public string Last
        {
            get { return last; }
            set { last = value; }
        }


        public string Middle
        {
            get { return middle; }
            set { middle = value; }
        }

        public string First
        {
            get { return first;}
            set { first = value; }
        }
    }
}
