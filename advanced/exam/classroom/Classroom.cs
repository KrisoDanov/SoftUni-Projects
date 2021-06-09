using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public int Capacity { get; set; }
        public int Count { get { return students.Count; } }

        public string RegisterStudent(Student student)
        {
            if (students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student studentToRemove = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }
        public string GetSubjectInfo(string subject)
        {
            List<Student> student = students.FindAll(x => x.Subject == subject);
            if (student.Any())
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine($"Subject: {subject}");
                output.AppendLine("Students:");
                foreach (var currStudent in student)
                {
                    if (currStudent.Subject == subject)
                    {
                        output.AppendLine($"{currStudent.FirstName} {currStudent.LastName}");
                    }
                }

                return output.ToString();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }
        public Student GetStudent(string firstName, string lastName)
        {
            Student getStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            return getStudent;
        }
        public int GetStudentsCount()
        {
            return Count;
        }
    }
}
