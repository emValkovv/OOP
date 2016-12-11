using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class StudentsAndWorkers
    {
        static void Main()
        {
            Workers emo = new Workers("Emanuil", "Valkov", 12);
            emo.WeekSalary = 250;
            emo.WorkHoursPerDay = 8;
            Console.WriteLine(emo.MoneyPerHour());

            List<Students> students = new List<Students>();
            List<Workers> workers = new List<Workers>();
            students.Add(new Students("Ivan", "Mladenov",2));
            students.Add(new Students("Dragan", "Toshev",5));
            students.Add(new Students("Cvetan", "Qnev",6));
            students.Add(new Students("Banan", "Petrov",5));
            students.Add(new Students("Nasran", "Dimitrov",5));
            students.Add(new Students("Eban", "Georgiev",1));
            students.Add(new Students("Ushan", "Stefanov",9));
            students.Add(new Students("Trahan", "Todorov",12));
            students.Add(new Students("Choban", "Ivanov",11));
            students.Add(new Students("Bratan", "Petkanov",8));

            workers.Add(new Workers("Maia", "Maneva", 250));
            workers.Add(new Workers("Katq", "Zeleva", 320));
            workers.Add(new Workers("Desi", "Lozova", 120));
            workers.Add(new Workers("Dani", "Rozeva", 90));
            workers.Add(new Workers("Mimi", "Laleva", 540));
            workers.Add(new Workers("Geri", "Paneva", 421));
            workers.Add(new Workers("Nikol", "Taneva", 432));
            workers.Add(new Workers("Riana", "Saneva", 432));
            workers.Add(new Workers("Preslava", "Baneva", 393));
            workers.Add(new Workers("Slava", "Maneva", 342));

            var query = from student in students
                        orderby student.Grade ascending
                        select student;
            foreach (var q in query)
            {
                Console.WriteLine(q.Grade);
            }

            var queryTwo = from worker in workers
                           orderby worker.MoneyPerHour() descending
                           select worker;

            foreach (var q in queryTwo)
            {
                Console.WriteLine(q.MoneyPerHour());
            }

            var merged = new List<Human>();
            merged.AddRange(students);
            merged.AddRange(workers);

            var result = merged.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            foreach (var element in result)
            {
                Console.WriteLine(element.FirstName + " " + element.LastName);
            }
        }
    }
}
