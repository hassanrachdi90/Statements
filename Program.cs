Console.WriteLine("-------------------Hello Statements-------------------");
Console.WriteLine("-------------------2-Logical-------------------");
static void Logical()
{
    bool a = true;
    bool b = false;
    bool resultat = true;
    resultat = a && b;
    Console.WriteLine($"{a} && {b} = {resultat} ");
    resultat = a || b;
    Console.WriteLine($"{a} || {b} = {resultat} ");
    resultat = !a;
    Console.WriteLine($"!{a} = {resultat} ");
    resultat = !b;
    Console.WriteLine($"!{b} = {resultat} ");
    resultat = a ^ b;
    Console.WriteLine($"{a} ^ {b} = {resultat} ");
    resultat = !(a || b);
    Console.WriteLine($"!({a} || {b}) = {resultat} ");
}
Logical();
Console.WriteLine("-------------------2-Assignment-------------------");
static void AssignmentLogical()
{
    int a = 21;
    int c;
    c = a;
    Console.WriteLine($"c = a: {c} ");
    c += a;
    Console.WriteLine($"c += a: {c} ");
    c -= a;
    Console.WriteLine($"c -= a: {c} ");
    c *= a;
    Console.WriteLine($"c *= a: {c} ");
    c /= a;
    Console.WriteLine($"c /= a: {c} ");
    c = 200;
    c %= a;
    Console.WriteLine($"c %= a: {c} ");//c=200%21=11 
    c <<= 2;
    Console.WriteLine($"c <<= 2: {c} ");// équivaut à c = c << 2 and c=11 1011 en binaire et c <<= 2 101100 en binaire = 44 en décimal (11<<2=11*2²=11*4=44)
    c >>= 2;
    Console.WriteLine($"c >>= 2: {c} "); // c = c << 2 and c=44 101100 en binaire et c >>= 2 1011 en binaire = 11 en décimal (4>>2=44/2²=44/4=11)
    c &= 2;
    Console.WriteLine($"c &= 2: {c} "); // c=11 1011 en binaire et c &= 2 0010 en binaire = 2 en décimal => Résultat : 1011 & 0010 = 0010 (2 en décimal) 
    c ^= 2;
    Console.WriteLine($"c ^= 2: {c} "); // c=2 0010 en binaire et c ^= 2 0010 en binaire = 0 en décimal => Résultat : 0010 ^ 0010 = 0000 (0 en décimal)
    c |= 2;
    Console.WriteLine($"c |= 2: {c} "); // c=0 0000 en binaire et c |= 2 0010 en binaire = 2 en décimal => Résultat : 0000 | 0010 = 0010 (2 en décimal)
}
AssignmentLogical();
Console.WriteLine("-------------------Miscellaneous-Operators------------------");

static void MiscellaneousLogical()
{
    //double a = 5.1;
    Console.WriteLine($"sizeof Double => : {sizeof(double)}");
    Console.WriteLine($"typeof Console => : {typeof(Console)}");
    Console.WriteLine($"typeof File a => : {typeof(File)}");
    bool IsType = typeof(Console) == typeof(System.Console);
    Console.WriteLine($"typeof Console == typeof(System.Console) => : {IsType}");
    object obj = 5;
    IsType = obj is int;
    Console.WriteLine($"obj is int => : {(IsType)}");
    IsType = obj is string;
    Console.WriteLine($"obj as string => : {(IsType)}");
    int? x = obj as int?;
    Console.WriteLine($"a as int? => : {(x)}");
}
MiscellaneousLogical();
Console.WriteLine("-------------------Statement------------------");
static void StatementConditional()
{
    Console.WriteLine("Welcome to Student Grade");
    Console.WriteLine("Enter your grade:");
    double grade = Convert.ToDouble(Console.ReadLine());

    if (grade >= 90)
    {
        Console.WriteLine("Excellent");

    }
    else if (grade >= 80)
    {
        Console.WriteLine("Très Bien");
    }
    else if (grade >= 70)
    {
        Console.WriteLine("Bien");
    }
    else if (grade >= 60)
    {
        Console.WriteLine("Assez Bien");
    }
    else if (grade >= 50)
    {
        Console.WriteLine("Passable");
    }
    else if (grade < 40 && grade >= 0)
    {
        Console.WriteLine("Insuffisant");
    }
    else
    {
        Console.WriteLine("Echec");
    }
}
StatementConditional();
Console.WriteLine("------------------- Exemple Statement------------------");
static void TaxCalculator()
{
    Console.WriteLine("TaxCalculator");
    Console.WriteLine("Welcome to Tax Calculator Salary ");
    Console.WriteLine("Enter your salary:");
    double salary = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter your Type : 1-Employee, 2-Business Man ");
    double type = Convert.ToDouble(Console.ReadLine());
    double tax;
    if (salary > 10000)
    {
        tax = 0;
        if (type == 1)
        {
            tax = salary - 10000;
            Console.WriteLine($"Tax : {tax}");
        }
        else if (type == 2)
        {
            tax = salary - (0.2 * salary);
            Console.WriteLine($"Tax : {tax}");
        }
    }
    else
    {
        Console.WriteLine("Salary must be greater than 10000");
    }
}
TaxCalculator();
static void TaxCalculator2()
{
    Console.WriteLine("TaxCalculator");
    Console.WriteLine("Welcome to Tax Calculator Salary ");
    Console.WriteLine("Enter your salary:");
    double salary = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter your Type : 1-Employee, 2-Business Man ");
    double type = Convert.ToDouble(Console.ReadLine());
    double tax;
    if (salary > 10000 && type == 1)
    {
        tax = 0;
        tax = salary - 10000;
        Console.WriteLine($"Tax : {tax}");
    }
    else if (salary > 10000 && type == 2)
    {
        tax = salary - (0.2 * salary);
        Console.WriteLine($"Tax : {tax}");
    }
    else
    {
        Console.WriteLine("Salary must be greater than 10000");
    }
}
TaxCalculator2();
Console.WriteLine("------------------- Statement Tenary Or Short Hand ------------------");
static void TaxCalculator3()
{
    Console.WriteLine("TaxCalculator");
    Console.WriteLine("Welcome to Tax Calculator Salary ");
    Console.WriteLine("Enter your salary:");
    double salary = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter your Type : 1-Employee, 2-Business Man ");
    double type = Convert.ToDouble(Console.ReadLine());

    double tax = (salary > 10000 && type == 1)
        ? salary - 10000 : (type == 2 && type == 2) ? salary - (0.2 * salary) : -1;
    Console.WriteLine(tax != -1
       ? $"Tax : {tax}"
       : "Salary must be greater than 10000");
    //autre ecriture  
    /*/string taxMessage = (salary > 10000 && type == 1)
            ? $"Tax: {salary - 10000} Taxe of Type 1"
            : (salary > 10000 && type == 2)
                ? $"Tax: {salary - (0.2 * salary)} Taxe of Type 2"
                : "Salary must be greater than 10000";

        Console.WriteLine(taxMessage);*/
}
TaxCalculator3();
Console.WriteLine("------------------- Statement Exercice ------------------");

static void MaxNumber()
{
    Console.WriteLine("Enter the first number:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the Thrid number:");
    int num3 = Convert.ToInt32(Console.ReadLine());
    int max ;
    max = (num1 > num2 && num1 > num3)? num1 : (num2 > num1 && num2 > num3)? num2 : num3;
    Console.WriteLine($"The maximum number is {max}");
}
MaxNumber();
Console.WriteLine("-------------------  SwitchCase Statement------------------");
    debut:
    Console.WriteLine("Enter a number between 1 and 7");
    int day = Convert.ToInt32(Console.ReadLine());
    switch (day)
    {
        case 1: Console.WriteLine("Monday"); break;
        case 2: Console.WriteLine("Tuesday"); break;
        case 3: Console.WriteLine("Wednesday"); break;
        case 4: Console.WriteLine("Thursday"); break;
        case 5: Console.WriteLine("Friday"); break;
        case 6: Console.WriteLine("Saturday"); break;
        case 7: Console.WriteLine("Sunday"); break;
        default: Console.WriteLine("Invalid day");//break;
            goto debut;
    }
Console.WriteLine("-------------------  Exercice SwitchCase ------------------");
 Console.WriteLine(" Welcome to Calculator");
    Console.WriteLine("Enter the first number:");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the operator:");
    string op = Console.ReadLine();
    Console.WriteLine("Enter the second number:");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double result = 0;
    switch (op)
    {
        case "+": result = num1 + num2; break;
        case "-": result = num1 - num2; break;
        case "*": result = num1 * num2; break;
        case "/": if (num2 == 0) { Console.WriteLine("Division by zero is not allowed"); break; }
                  else {result = num1 / num2 ; break;}  
        default: Console.WriteLine("Invalid operator"); break;
    }
    Console.WriteLine($"The result is {result}");  
Console.WriteLine("-------------------  While ------------------");
static void WhileLoop()
{
    int i = 1;
    while (i <= 5)
    {
        Console.WriteLine(i);
        i++;
    }
}
WhileLoop();
Console.WriteLine("-------------------   While Break and continue ------------------");
static void WhileContinue(){
    int i = 1;
       while (i <= 10)
    {
        if(i==5){
            i++;
            continue;
        }
        Console.WriteLine(i);
        i++;
    }
}
WhileContinue();
static void WhileBreak(){
    int i = 1;
    while (i <= 10)
    {
        if(i==5){
            break;
        }
        Console.WriteLine(i);
        i++;
    }
}
WhileBreak();
 Console.WriteLine("-------------------   Exercice  While ------------------");
static void WhileExercice(){
    int i = 0;
    int j = 0;
    int sum = 0;
    while (i < 10)
    {
        j = 0;
        while (j < 10)
        {
            sum = i * j;
            Console.WriteLine($"{i} * {j} = {sum}");
            j++;
        }
        Console.WriteLine("=====================");
        i++;
    }
}
WhileExercice();
Console.WriteLine("-------------------  DoWhile ------------------");
static void DoWhileLoop()
{
    int i = 1;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i <= 5);
}
DoWhileLoop();
Console.WriteLine("-------------------   DoWhile Break and continue ------------------");

static void DoWhileContinue(){
    int i = 1;
    do
    {
        if(i==5){
            i++;
            continue;
        }
        Console.WriteLine(i);
        i++;
    } while (i <= 10);
}
DoWhileContinue();

static void DoWhileBreak(){
    int i = 1;
    do
    {
        if(i==5){
            break;
        }
        Console.WriteLine(i);
        i++;
    } while (i <= 10);
}
DoWhileBreak();
Console.WriteLine("-------------------   Exercice  DoWhile ------------------");
static void DoWhileExercice()
{
    int i = 0;
    int j = 0;
    int sum = 0;
    do
    {
        j = 0;
        do
        {
            sum = i * j;
            Console.WriteLine($"{i} * {j} = {sum}");
            j++;
        } while (j < 10);
        Console.WriteLine("=====================");
        i++;
    } while (i < 10);
}
DoWhileExercice();
Console.WriteLine("------------------- Foreach ------------------");

int[] numbers = { 1, 2, 3, 4, 5 };

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------------   Exercice Foreach  ------------------");
static void foreachExercice()
{
    int[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    foreach (var num1 in i)
    {
        foreach (var num2 in i)  
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }
        Console.WriteLine("====================="); 
    }
}
foreachExercice();
Console.WriteLine("-------------------  For ------------------");
static void ForLoop()
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine(i);
    }
}
ForLoop();
Console.WriteLine("-------------------   Exercice  For ------------------");

static void ForExercice()
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine($"{i} * {j} = {i * j}");
        }
        Console.WriteLine("=====================");
    }
}
ForExercice();

Console.WriteLine("Please enter a number");
int numb = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= numb; i++)
{
    for(int j = 0; j <i; j++){
        Console.Write(" * ");
    }
    Console.WriteLine("");
}
Console.WriteLine("-------------------   Break ------------------");

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}

Console.WriteLine("-------------------   Continue ------------------");

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        i++;
        continue;
    }
    Console.WriteLine(i);
}