// 1. Tub sonlar

System.Console.Write("Sonni kiriting:");
int number = Convert.ToInt32(Console.ReadLine());
if( number > 1)
{
    int a = 2;
    int S = 0;
    while(a <= number)
    {
        if(number%a==0)
        {
            S++;
        }
        a++;
    }
    if(S>1)
    {
        System.Console.WriteLine("Tub emas");
    }
    else
    {
        System.Console.WriteLine("Tub son");
    }
}
else
{
    System.Console.WriteLine("Birdan katta son kiriting!");
}

// 2. Bo'luvchisiz sonlar

System.Console.Write("Sonni kiriting:");
int x = Convert.ToInt32(Console.ReadLine());
int i = 2;
System.Console.WriteLine("Bo'luvchilari:");
for(i = 2; i <=10; i++)
{
    if(x%i==0)
    {
        System.Console.WriteLine($"{i},");
    }
}

// 3. Daraja hisoblash:

System.Console.Write("Soni kiriting:");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Darajani kiriting:");
int number2 =  Convert.ToInt32(Console.ReadLine());
if(number2 > 0)
{
    System.Console.WriteLine(Math.Pow(number1,number2));
}
else
{
    System.Console.WriteLine("Darajaga musbat sonni kiriting!");
}

// 4. Harajatlar to'plamini hisoblash: 

System.Console.Write("Sonlarni kiriting:");
string input = Console.ReadLine();
int[] exprenses = input.Split(',')
                       .Select(int.Parse)
                       .ToArray();
int totalExpense = exprenses.Sum();
System.Console.WriteLine($"Umumiy xarajat={totalExpense}");

// 5. Armstrong sonlar:

System.Console.Write("Soni kiriting:");
int armstrong = int.Parse(Console.ReadLine());

if(IsArmstrong(armstrong))
{
    System.Console.WriteLine($"{armstrong} Armstrong son!");
}
else
{
    System.Console.WriteLine($"{armstrong} Armstrong son emas!");
}

bool IsArmstrong (int armstrong)
{
    int digitsCount = armstrong.ToString().Length;
    int sum = 0;
    int temp = armstrong;
    while(temp>0)
    {
        int digit = temp%10;
        sum += (int)Math.Pow(digit,digitsCount);
        temp /=10;
    }
    return sum == armstrong;
}

// 6. Sifatli bo'luvchilar:

System.Console.Write("Sonni kiriting:");
int n = int.Parse(Console.ReadLine());
int counter = 0;
for(int p = 1; p < n; p++)
{
    if(n%p == 0)
    {
        counter++;
    }
}
    System.Console.WriteLine(counter);


