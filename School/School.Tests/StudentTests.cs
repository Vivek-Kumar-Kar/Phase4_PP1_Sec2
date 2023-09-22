using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Pradeep Sarkar";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("Pradeep Sarkar", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "Saheed Nagar";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("Saheed Nagar", studentAddress);
        }
    }
}
