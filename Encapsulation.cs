using System;

class Student
{
    private string name = "Jack Brown";

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }
}

class Test
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.SetName("Hari Sempulur");
        Console.WriteLine(s.GetName());
    }
}
