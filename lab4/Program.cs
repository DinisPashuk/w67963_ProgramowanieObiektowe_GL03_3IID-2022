using lab4.Zadanie_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
        {
            new Rectangle(),
            new Triangle(),
            new Circle()
        };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }


             var pesels = new List<long>()
            {
                13292313574,
                11272558326,
                11252623556,
                14222195514,
                13260515371,
                14281248851,
                13211445544,
                13290928392,
                14240472824,
                12310555824
            };

            var teacher = new Nauczyciel();

            teacher.SetFirstName("Nauczyciel");
            teacher.SetLastName("Nauczyciel");
            teacher.TytulNaukowy = "Dr";

            var students = new List<Uczen>();

            var i = 0;
            foreach(var pesel in pesels)
            {
                var student = new Uczen();
                student.SetPesel(pesel.ToString());
                student.SetFirstName("Student");
                student.SetLastName(i.ToString());
                if (i == 4)
                    student.SetCanGoHomeAlone(true);
                students.Add(student);
                i++;
            }

            teacher.PodwladniUczniowie.AddRange(students);

            teacher.WhichStudentCanGoHomeAlone();

            teacher.PrintInfo(DateTime.Today);
        }
    }
}
