using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Tutor
    {
        int TutorID;
        string TutorName;

        public void SetTutor(int id, string name)
        {
            TutorID = id;
            TutorName = name;
        }
        public int GetTutorID()
        {
            return TutorID;
        }
        public string GetTutorName()
        {
            return TutorName;
        }
        static void Main(string[] args)
        {
            Tutor t = new Tutor();
            t.SetTutor(101,"K.B.M");
            t.GetTutorID();
            Console.WriteLine(t.GetTutorID());
            Console.WriteLine(t.GetTutorName()+" sir");
            Console.ReadKey();
        }
    }
}
