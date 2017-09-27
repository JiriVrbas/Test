using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static List<Student> students = new List<Student>();

        public void AddChrist()
        {
            students.Add(new Student()
            {
                Id = 888,
                Name = "Christ",
                Age = 33
            });
        }

        public void AddDevil()
        {
            students.Add(new Student()
            {
                Id = 666,
                Name = "Hell",
                Age = 1555
            });
        }
        public void AddGeorge()
        {
            students.Add(new Student()
            {
                Id = 100,
                Name = "George",
                Age = 11
            });
        }

        public string GetInfo(Student student)
        {
            return student.Name + " (" + student.Age + ")";
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public Student FindStudent(int id)
        {
            return students.Find(x => x.Id == id);
        }

        public bool RemoveStudent(int id)
        {
            return students.Remove(students.Find(x => x.Id == id));
        }

        public void EditStudent(Student student)
        {
            var st = students.Find(x => x.Id == student.Id);
            if (st != null)
            {
                st.Name = student.Name;
                st.Age = student.Age;
                students.Remove(students.Find(x => x.Id == st.Id));
                students.Add(st);
            }
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
