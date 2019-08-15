using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models


{
    public static class Repository
    {
        private static List<Student> _students = new List<Student>();
        

        public static List<Student> Students()
        {

            return _students;
        }

        public static void AddStudent(Student st)
        {
            using (StreamWriter sw = new StreamWriter(("names.txt")))
            {
            _students.Add(st);
            sw.WriteLine(JsonConvert.SerializeObject(st));
            sw.Flush();

            }
           
            
        }

        

    }
}
