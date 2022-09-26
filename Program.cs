/*Exercise 1:
Create a new C# .Net Core Console App
Create a class named Car - make sure it is public
In the Car class:
Create a Make property of type string that is public
Create a Model property of type string that is public
Create a Year property of type int that is public
In the Main method:
Create a new instance of the Car class
Set values in the properties for the object
Print the values of each property to the Console*/

using ClassesCarExercise1;

Car newWhip = new Car() {Make = "Ferrari", Model = "488 Spider", Year = 2017 };
Console.WriteLine(newWhip.Make);
Console.WriteLine(newWhip.Model);
Console.WriteLine(newWhip.Year);

