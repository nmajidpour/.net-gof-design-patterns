using System.Collections.Generic;

// ConcreteSubject class
public class Course : Subject
{
   private List<Student> students = new List<Student>();
    public Course()
    {
    }

    public void AddStudent(Student student) {
        if(!students.Contains(student)) {
            AddObservers(student);
        }
    }

    public void AddLecture() {
        NotifyObservers();
    }
}