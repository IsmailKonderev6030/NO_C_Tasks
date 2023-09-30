using System;

class Tasks{

      // Task 25
    public static int Pow(int a, int b){
      int res = a;

      while(b>1){
        res *= a;
        b--;
      }

      return res;
    }
      // Task 27
    public static int sumNumber(int number){
      int res = 0;

      while(number>9){
        int temp = number%10;
        number /= 10;
        res += temp;
      }

      res += number;
      return res;
    }

    // Task 29
    public static void randomArr(int[] arr){
      Random rnd = new Random();

      for(int i=0;i<arr.Length;i++) 
          arr[i] = rnd.Next(0,10);

      return;
    }
    static void Main(){
      // Task 25
      {
      int a,b;
      Console.Write("Enter A:= ");
      a = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter B:= ");
      b = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Pow:= " + Pow(a,b) + "\n");
      }

      // Task 27
      {
        int a;
        Console.Write("Enter number:= ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum:= " + sumNumber(a) + "\n");
      }

      // Task 29
      {
        int[] arr = new int[8];
        randomArr(arr);

        Console.Write("[");
        for(int i=0;i<arr.Length-1;i++)
          Console.Write(arr[i] + ", ");
        Console.Write(arr[arr.Length-1] + "]\n");
      }
    }
}
