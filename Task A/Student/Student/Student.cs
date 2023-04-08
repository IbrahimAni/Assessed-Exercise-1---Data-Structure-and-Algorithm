using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    /// <summary>
    /// Represents a student with a name, ID, and age.
    /// </summary>
    internal class Student
    {
        private string name;
        private string id;
        private int age;

        /// <summary>
        /// Gets or sets the name of the student.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the ID of the student.
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Gets or sets the age of the student.
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Gets a string containing the student's name, ID, and age.
        /// </summary>
        /// <returns>A string containing the student's name, ID, and age.</returns>
        public string GetInformation()
        {
            return $"Name: {Name}, ID: {Id}, Age: {Age}";
        }
    }
}
