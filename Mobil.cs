using System;

//abstract class
abstract class Car 
{
    public abstract void gas(int add_speed);
    public abstract void brake(int reduce_speed);
}

class Sedan : Car
{
    private string model;
    private string color;
    private int current_speed = 0;

    public Sedan(string color, string model){
        this.color = color;
        this.model = model;
    }

    public override void gas(int add_speed)
    {
        this.current_speed += add_speed;
        Console.WriteLine($"Your car is accelerating! Your current speed is {this.current_speed}");
    }

    public override void brake(int reduce_speed)
    {
        if((this.current_speed - reduce_speed) > 0){
            this.current_speed -= reduce_speed;
            Console.WriteLine($"Your car is slowing down! Your current speed is {this.current_speed}");
        }
        else{
            this.current_speed = 0;
            Console.WriteLine("Your car is stop!");
        }
    }
}

class Mobil {
    static void Main(string[] args)
    {
        Sedan mobilku;
        mobilku = new Sedan("red", "sedan");

        mobilku.gas(10);
        mobilku.gas(20);
        mobilku.gas(70);
        mobilku.brake(50);
        mobilku.brake(50);
    }
}