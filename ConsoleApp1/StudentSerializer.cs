using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// A class used to serialize student objects 
    /// </summary>
     class StudentSerializer
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };


        /// <summary>
        /// Serializes an student object and prints this to a file
        /// </summary>
        /// <param name="student"> The student to serialize </param>
        public static void SerializeStudent(Student student)
        {
            string jsonString = JsonSerializer.Serialize(student);
            System.Console.WriteLine(jsonString);
        }


    }
}
