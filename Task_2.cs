using System;

class Person
{
    private double height;  
    private double weight;   
    private int birthYear;   
    private string lastName; 

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public Person()
    {
        height = 0.0;
        weight = 0.0;
        birthYear = 0;
        lastName = "Невiдомий";
    }

    public Person(double height, double weight, int birthYear, string lastName)
    {
        this.height = height;
        this.weight = weight;
        this.birthYear = birthYear;
        this.lastName = lastName;
    }

    public void Display()
    {
        Console.WriteLine($"Прiзвище: {lastName}, Зрiст: {height} м, Вага: {weight} кг, Рiк народження: {birthYear}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення трьох об'єктів класу Person
        Person person1 = new Person(1.75, 68.5, 1990, "Iваненко");
        Person person2 = new Person(1.80, 80.0, 1985, "Петренко");
        Person person3 = new Person(1.65, 60.0, 2000, "Сидоренко");

        // Виведення інформації про кожну людину
        person1.Display();
        person2.Display();
        person3.Display();

        // Обчислення середньої ваги
        double averageWeight = (person1.Weight + person2.Weight + person3.Weight) / 3;

        // Виведення середньої ваги
        Console.WriteLine($"Середня вага: {averageWeight} кг");
    }
}
