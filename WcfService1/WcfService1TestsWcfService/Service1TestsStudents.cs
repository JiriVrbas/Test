using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfService1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1.Tests
{
    [TestClass()]
    public class Service1TestsStudents
    {
        IService1 ser = new Service1();
        [TestMethod()]
        public void AddStudentTest()
        {
            int before = ser.GetAllStudents().Count;
            ser.AddStudent(new Student()
            {
                Id = 1,
                Name = "Jiří",
                Age = 25
            });
            int now = ser.GetAllStudents().Count;
            Assert.AreEqual(before + 1, now);
        }
        [TestMethod()]
        public void FindStudent()
        {
            var student = new Student()
            {
                Id = 2,
                Name = "Hanz",
                Age = 37
            };
            ser.AddStudent(student);
            Assert.IsNotNull(ser.FindStudent(2));
        }
        [TestMethod()]
        public void RemoveStudent()
        {
            var student = new Student()
            {
                Id = 3,
                Name = "Kirke",
                Age = 32
            };
            ser.AddStudent(student);
            ser.RemoveStudent(3);
            Assert.IsNull(ser.FindStudent(3));
        }
        [TestMethod()]
        public void EditStudent()
        {
            var student = new Student()
            {
                Id = 3,
                Name = "Kirke",
                Age = 32
            };
            ser.AddStudent(student);
            ser.EditStudent(new Student()
            {
                Id = 3,
                Name = "Karlos",
                Age = 32
            });
            Assert.AreEqual(ser.FindStudent(3).Name,"Karlos");
        }
        [TestMethod()]
        public void GetAllStudents()
        {
            Assert.IsNotNull(ser.GetAllStudents());
        }
        [TestMethod()]
        public void TestNothing()
        {
            ser.Nothing();
            Assert.IsTrue(true);
        }
    }
}