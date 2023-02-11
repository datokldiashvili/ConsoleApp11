using System.Diagnostics;
using System.Security.Principal;

//For Loop amocana
int i, j, rows;
Console.Write("Shemoiyvanet rigebis raodenoba: ");
rows = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= rows; i++)
{
    for (j = 1; j <= i; j++)
    {
        Console.Write(i);
    }
    Console.Write("/n");
}
//Null magaliti
string word = "";
string word2 = null;

Console.WriteLine("number is : " + word.Length);
Console.WriteLine("number is :" + word2.Length);

//amocana 
static bool ContainsLowerLetter(string password)
{
    char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
    foreach (char letter in lowerLetters)
    {
        if (password.Contains(letter))
        {
            return true;
        }

    }
    return false;
}

static bool ContainsUpperLetter(string password)
{
    char[] upperLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
    foreach (char letter in upperLetters)
    {
        if (password.Contains(letter))
        {
            return true;
        }
    }
    return false;
}

static bool ContainsInteger(string password)
{
    int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    foreach (int num in numbers)
    {
        if (password.Contains(num.ToString()))
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine("paroli unda sheicavdes did asos, patara asos da cifrs: ");
string password = Console.ReadLine();
bool passwordIsValid = ContainsLowerLetter(password) && ContainsUpperLetter(password) && ContainsInteger(password);

while (!passwordIsValid)
{
    Console.WriteLine("paroli arasworia. paroli unda sheicavdes did asos, patara asos da cifrs: ");
    password = Console.ReadLine();
    passwordIsValid = ContainsLowerLetter(password) && ContainsUpperLetter(password) && ContainsInteger(password);
}
Console.WriteLine(passwordIsValid);
//amocna  
static int Casino(int money, int number, int winningNumber)
{
    if (number == winningNumber)
    {
        return money * 10;
    }
    else if (number < winningNumber)
    {
        return 0;
    }
    else
    {
        return money * 2;
    }
}

Console.Write("shemoitanet fsoni: ");
int money = Convert.ToInt32(Console.ReadLine());

Console.Write("romel ricxvze debt? (0-dan 36-is chatvlit): ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 0 || number > 36)
{
    Console.Write("Shemoitanet ricxvi 0-idan 36-is chatvlit:  ");
    number = Convert.ToInt32(Console.ReadLine());
}
Random rnd = new Random();
int winningNumber = rnd.Next(37);

Console.WriteLine("mogebuli ricxvi aris " + winningNumber);
Console.WriteLine("tqveni tanxaa: " + Casino(money, number, winningNumber) + "lari");

Console.ReadKey();

//class

class Student
{
    string Name;
    string Surname;
    int Age;

    public Student(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    ~Student()
    {
        Console.WriteLine("klasis obieqti waishala");
    }
}

//clasis tvisebebi 

class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
}




