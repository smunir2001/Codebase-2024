namespace Collections;

public class Student
{
    public int id {get; set;}

    public string name {get; set;}

    public float gpa {get; set;}

    public Student(int id, string name, float gpa) {
        this.id = id;
        this.name = name;
        this.gpa = gpa;
    }
}