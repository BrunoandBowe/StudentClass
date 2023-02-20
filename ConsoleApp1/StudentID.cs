using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class StudentID
    {
        private string id;



        public StudentID(string id)
        {
            this.id = id;
        }


        public string ID
        {
            get { return id; }
            set 
            {
                if(value.Length < 6)
                {
                    id = value;
                }
            }
        }


    }
}
