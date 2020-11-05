/*

Encapsulation is nothing new to what we have read, it is just a concept. 
It is the way of combining the data and methods inside a class. 
Thus the data gets hidden from being accessed directly from outside the class. 
This is similar to a capsule where several medicines are kept inside the capsule 
thus hiding them from being directly consumed from outside. 
All the members of a class are private by default, thus preventing them from 
being accessed from outside the class.

*/

/*
-----------------
Why Encapsulation?
-----------------
Encapsulation is necessary to keep the details about an object hidden from the users of 
that object. Details of an object are stored in its data members. 
This is the reason we make all the member variables of a class private and 
most of the member methods public. Member variables are made private 
so that these cannot be directly accessed from outside the class 
(to hide the details of any object of that class like how the data 
about the object is implemented) and so most member methods are made 
public to allow the users to access the data members through those methods.

*/

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