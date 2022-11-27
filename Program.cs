// TASK 19

/*Console.WriteLine("Enter the five-digit number");
string arr = Console.ReadLine();
int Len = arr.Length;

if (Len == 5 )
{
    if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        Console.WriteLine($"{arr} - is a palindrome");
    }
    else
    {
        Console.WriteLine($"{arr} - is not a palindrome");
    }
}
else
{
    Console.WriteLine($"{arr} - is not a five-digit number");
}
Console.WriteLine();*/

// TASK 21

/*Console.WriteLine("Enter the x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double Result = Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)+Math.Pow((z2-z1), 2));
Console.WriteLine(Result);*/

// TASK 23

Console.WriteLine("Enter the number N");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= N)
{
    Console.WriteLine(Math.Pow(count,3));
    count++;
}
Console.WriteLine();