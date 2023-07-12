
string greeting = GetHelloUser("Omar");
Console.WriteLine(greeting);
string name = "Alice";
string greeting2 = GetHelloUser(name);
Console.WriteLine(greeting2);
Console.WriteLine(GetHelloUser("Bob"));
string userName = GetCleanInput();
Console.WriteLine(userName);
double sum = AddThreeNumbers(9, 5, 3);
Console.WriteLine(sum);
DisplayDate();



// methods
static string GetHelloUser(string user)
{
    string result = $"Hello, {user}";
    return result ;
}

static string GetCleanInput() // has no input in ()
{
    Console.WriteLine("Please enter a name");
    return Console.ReadLine().ToLower().Trim(); // makes it lower case and removes outer space
}

static double AddThreeNumbers(double x, double y, double z)
{
    return x + y + z;
}

// void means no return
static void DisplayDate()
{
    DateTime date = DateTime.Now;       // consolewriteline used for void
    Console.WriteLine(date);
}


// Excercises

//1

int conversion = ConvertMinuteToSeconds(50);
Console.WriteLine($"This is {conversion} seconds.");
static int ConvertMinuteToSeconds(int minutes)
{
    return minutes * 60;
}

//2

double area = AreaTriangle(5,3);
static double AreaTriangle(double height, double length)
{
    return area = (height * length) / 2;
}

//3

Console.WriteLine(convertNegative(-3));
static int convertNegative(int x)
{
    if (x <= 0)
    {
        return x;
    }
    else
    {
        return -x;
    }
}

//4

Console.WriteLine(convertPositive(3));
static int convertPositive(int x)
{
    if (x >= 0)
    {
        return x;
    }
    else
    {
        return x * -1;
    }
}


/*int positive = ConvertPositive(-3);
Console.WriteLine(positive);
static int ConvertPositive(int negative)
{
    int positive = negative * -1;
    return positive;
}
*/

//5

GreetUser();

static void GreetUser()
{
    Console.WriteLine("What is your name");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello {name}");
}


// called isEnoughMoney. Take in 2 doubles, cost and payment. It will return a bool.
// if there is enough payment. return a true. else return a false


static bool IsEnoughMoney(double cost, double payment)
{
    if (payment > cost)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// method called GetHouse. Take in a double called salary and it will return a string
// 60k or less, get an apartment
// 80k or less, you can get a 1 br house
// 100k or less, it will be a 2 br house
// anything greater will be a 3 br house

static string GetHouse(double salary)
{
    if (salary <= 60000)
    {
        return "Apartmnet";
    }
    else if (salary <= 80000)
    {
        return "1 br house";
    }
    else if (salary <= 100000)
    {
        return "2 br house";
    }
    else
    {
        return "3 br house";
    }
}


// this method is called CombineWords.
// this will take in 3 strings and wil return a string. Combine all 3 parameters into 1 string that is separated by ,
// apple orange banana => apple, orange, banana


static string CombineWords(string x, string y, string z)
{
    return $"{x}, {y}, {z}";
}