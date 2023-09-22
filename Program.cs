using System.Diagnostics;

int a,b,c;
int max,min;

// Task 2
Console.WriteLine("Task 2\n\n");
Console.WriteLine("Enter first number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
b = Convert.ToInt32(Console.ReadLine());

if(a<=b) {min = a; max = b;}
else     {min = b; max = a;}

Console.WriteLine("max:= " + max);
Console.WriteLine("min:= " + min + '\n');

// Task 4
a=b=c=max=0;

Console.WriteLine("Task 4\n\n");
Console.WriteLine("Enter first number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number: ");
c = Convert.ToInt32(Console.ReadLine());

if(a>=b) max = a;
else max = b;
if(max<c) max = c;

Console.WriteLine("max:= " + max + '\n');

// Task 6
a=0;

Console.WriteLine("Task 6\n\n");
Console.WriteLine("Enter number:= ");
a = Convert.ToInt32(Console.ReadLine());

if(a%2 == 0){Console.WriteLine("Yes\n"); }
else        {Console.WriteLine("No\n" );  }

// Task 8
a=0;
b=2;

Console.WriteLine("Task 8\n\n");
Console.WriteLine("Enter number:= ");
a = Convert.ToInt32(Console.ReadLine());

while(b<=a){
    Console.WriteLine(b);
    b+=2;
}