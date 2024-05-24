﻿namespace Chap6_CarTest;

class CarTargetType
{
    
    static readonly Dictionary<int, Car> cars = new();

    static void Main()
    {
        Car mycar = new();
        mycar.name = "CX-30";

        cars.Add(1, mycar);
        cars.Add(2, new());

        cars[2].name = "GT-R";

        Console.WriteLine(cars[1].name);   
        Console.WriteLine(cars[2].name);   
    }
}