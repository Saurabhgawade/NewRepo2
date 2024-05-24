using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializeJson
{
    public class Rootobject
    {
        public Student[] Property1 { get; set; }
    }

    public class Student
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int physics { get; set; }
        public int maths { get; set; }
        public int english { get; set; }
    }

}

