using System.Collections.Generic;

namespace task3
{
    public class StudentsGroup: GroupPrototype
    {
        public string groupName;
        public string faculty;
        protected List<Student> students;

        public StudentsGroup(string groupName, string faculty)
        {
            this.groupName = groupName;
            this.faculty = faculty;
            this.students = new List<Student>();
        }

        protected StudentsGroup(StudentsGroup group)
        {
            this.groupName = group.groupName;
            this.faculty = group.faculty;
            this.students = group.students;
        }

        public bool Add(Student student)
        {
            foreach(Student st in this.students)
            {
                if(st.id == student.id)
                {
                    return false;
                }
            }
            students.Add(student);
            return true;
        }

        public bool Remove(Student student)
        {
            return students.Remove(student);
        }

        public void Print()
        {
            System.Console.WriteLine($"Group name: {this.groupName}\r\nFaculty: {this.faculty}\r\nStudents:");
            foreach(Student student in this.students)
            {
                System.Console.WriteLine(student);
            }
        }

        public StudentsGroup Clone()
        {
            return new StudentsGroup(this);
        }
    }
}