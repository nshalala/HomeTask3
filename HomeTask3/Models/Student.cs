namespace HomeTask3.Models;

internal class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public double Point;
    public bool IsGraduated;

    public Student(string name, string surname, string group, double point, bool isGraduated)
    {
        Name = name;    
        Surname = surname;  
        Group = group;
        Point = point;
        IsGraduated = isGraduated;
    }

    public string FullName()
    {
        return $"{Name} {Surname}";
    }

    public string Info()
    {
        return $"{FullName()} {Group} - {Point} point : {Graduated()}";
    }

    public string Graduated()
    {
        return IsGraduated ? "graduated" : "still studying";
    }

    public string SecondChance()
    {
        return (Point > 80) ? "eligible" : "not eligible";
    }
}
