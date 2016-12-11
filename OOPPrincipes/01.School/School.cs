using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class School
    {
        static void Main()
        {
            Teacher emo = new Teacher("Emanuil");
            emo.AddDiscipline(new Disciplines("Bel", 12, 11));
            emo.AddDiscipline(new Disciplines("Mat", 12, 11));
            emo.AddDiscipline(new Disciplines("Angl", 12, 11));
            emo.AddDiscipline(new Disciplines("Fizika", 12, 11));
            emo.RemoveDiscipline(emo.GetList(), 1);
            emo.Print(); 
    
        }
    }
}
