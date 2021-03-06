using System;
using System.Collections.Generic;
using System.Text;

namespace pract7
{
    class Student : Man
    {
        public string faculty;
        public string course;
        public string group;


        public Student(string inName, int inAge, string inSex, int inWeight, string inFaculty, string inCourse, string inGroup) : base(inName, inAge, inSex, inWeight)
        {
            faculty = inFaculty;
            course = inCourse;
            group = inGroup;
        }

        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }

        public string Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }

        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }

        public new string ShowInformation()
        {
            string info = "Имя человека - " + name + "\n" + "Пол - " + sex + "\n" + "Вес - " + weight + "кг\n" + "Возраст (лет) - " + age + "\nФакультет - " + faculty + "\nГруппа/специальность - " + group + "\nКурс - " + course;
            return info;
        }

        public static Student operator ++(in Student he)
        {
            he.Age = he.Age + 1;
            return he;
        }
    }
}
