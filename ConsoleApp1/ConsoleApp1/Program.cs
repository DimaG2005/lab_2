using System;

// Клас Address
public class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        this.index = index;
        this.country = country;
        this.city = city;
        this.street = street;
        this.house = house;
        this.apartment = apartment;
    }

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

// Клас Converter
public class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUsd(double uah)
    {
        return uah / usd;
    }

    public double ConvertToEur(double uah)
    {
        return uah / eur;
    }

    public double ConvertToPln(double uah)
    {
        return uah / pln;
    }

    public double ConvertFromUsd(double amount)
    {
        return amount * usd;
    }

    public double ConvertFromEur(double amount)
    {
        return amount * eur;
    }

    public double ConvertFromPln(double amount)
    {
        return amount * pln;
    }
}

// Клас Employee
public class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalary(string position, int experience)
    {
        // Реалізуйте логіку розрахунку окладу та податкового збору за вказаними умовами
        // (це може бути власний клас Salary з методами розрахунку)
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        // Додайте виведення інших даних про співробітника
    }
}

// Клас User
public class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Логін: {login}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Вік: {age}");
        Console.WriteLine($"Дата заповнення анкети: {registrationDate}");
    }
}

class Program
{
    static void Main()
    {
        // Приклад використання класу Address
        Address myAddress = new Address("12345", "Україна", "Київ", "Вулиця", "1", "10");
        Console.WriteLine("Адреса:");
        Console.WriteLine($"Індекс: {myAddress.Index}");
        Console.WriteLine($"Країна: {myAddress.Country}");
        Console.WriteLine($"Місто: {myAddress.City}");
        Console.WriteLine($"Вулиця: {myAddress.Street}");
        Console.WriteLine($"Будинок: {myAddress.House}");
        Console.WriteLine($"Квартира: {myAddress.Apartment}");

        // Приклад використання класу Converter
        Converter myConverter = new Converter(27.5, 33.2, 7.8);
        double amountInUah = 1000;
        Console.WriteLine($"{amountInUah} UAH = {myConverter.ConvertToUsd(amountInUah)} USD");
        Console.WriteLine($"{amountInUah} UAH = {myConverter.ConvertToEur(amountInUah)} EUR");
        Console.WriteLine($"{amountInUah} UAH = {myConverter.ConvertToPln(amountInUah)} PLN");

        // Приклад використання класу Employee
        Employee employee = new Employee("Петров", "Іван");
        employee.CalculateSalary("Програміст", 5);
        employee.DisplayInfo();

        // Приклад використання класу User
        User user = new User("user123", "Іван", "Петров", 25);
        user.DisplayInfo();
    }
}
