using System.Diagnostics;
int a;

// Task 10
Console.WriteLine("Task 10\n");
Console.WriteLine("Enter number:= ");
a = Convert.ToInt32(Console.ReadLine());

a = a % 100;
a = a / 10;

Console.WriteLine(a + "\n");


// Task 13
a=0;

Console.WriteLine("Task 13\n");
Console.WriteLine("Enter number:= ");
a = Convert.ToInt32(Console.ReadLine());
if(a<100) Console.WriteLine("number < 100\n");
else{
    while(a>=1000) a = a / 10;
    Console.WriteLine(a%10 + "\n");
}

// Task 15
a=0;
Console.WriteLine("Task 15\n");
Console.WriteLine("Enter number:= ");
a = Convert.ToInt32(Console.ReadLine());
if(a>5) Console.WriteLine("Yes");
else    Console.WriteLine("No");
