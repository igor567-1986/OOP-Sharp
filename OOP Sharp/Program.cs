using static System.Console;
//Статическое поле класса
/*Person bob = new(68);
bob.CheckAge();
Person bred = new(34);
bred.CheckAge();
WriteLine(Person.retirementAge);
Person.retirementAge = 67;
WriteLine(Person.retirementAge);
class Person
{
    int age;
    public static  int retirementAge = 65;
    public Person(int age)
    {
        this.age = age;
    }
    public void CheckAge()
    {
        if (age >= retirementAge)
            WriteLine("Уже на пенсии");
        else
            WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
    }
}*/
//Статические свойства
/*Person ted = new(70);
ted.CheckAge();
WriteLine(Person.RetirementAge);
Person.RetirementAge = 60;
WriteLine(Person.RetirementAge);
class Person
{
    int age;
    static int retirementAge = 65;
    public static int RetirementAge
    {
        get { return retirementAge; }
        set { if (value > 1 && value < 100) retirementAge = value; }
    }
    public Person(int age)
    {
        this.age = age;
    }
    public void CheckAge()
    {
        if (age >= retirementAge)
            WriteLine("Уже на пенсии");
        else
            WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
    }
}*/
//Cтатические методы
/*Person ted = new(71);
Person.CheckRetirementStatus(ted.Age);
class Person
{
    public int Age { get; set; }
    static int retirementAge = 65;
    public Person(int age) => Age = age;
    public static void CheckRetirementStatus(int Age)
    {
        if (Age >= retirementAge)
            WriteLine("Уже на пенсии");
        else
            WriteLine($"Сколько лет осталось до пенсии: {retirementAge - Age}");
    }
}
*/
//Статический конструктор
/*Person Morgo=new(49,true);
Person Bill = new(53, false);
Morgo.CheckAge();
Bill.CheckAge();
class Person
{
    static int retirementAgeM=65;
    static int retirementAgeW = 55;
    bool gender;
    int age;
    public void SetAge(int age)
    {
        this.age = age;
    }
    //public int Age()
    //{
    //    return age;
    //}
    public void SetGender(bool gender)
    {
        this.gender = gender;
    }
    //public bool Gender()
    //{
    //    return gender;
    //}
    public Person(int age,bool gender)
    {
        SetAge(age);
        SetGender(gender);
    }
    public void CheckAge()
    {
        if (gender == true)
            if (age >= retirementAgeW)
                WriteLine("Уже на пенсии");
            else
                WriteLine($"Сколько лет осталось до пенсии: {retirementAgeW - age}");
        else
            if (age >= retirementAgeM)
            WriteLine("Уже на пенсии");
        else
            WriteLine($"Сколько лет осталось до пенсии: {retirementAgeM - age}");
    }
}*/
//Статические классы
/*WriteLine(Operations.Add(5, 4));
WriteLine(Operations.Subtract(5, 4));
WriteLine(Operations.Multiply(5, 4));
static class Operations
{
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;//{return x-y;}
    public static int Multiply(int x, int y) => x * y;
}*/
//null
string? name = null;

int? val = null;
getvalueordeafult
