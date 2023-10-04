using System;
using System.Buffers;

class Tasks{
    public static void randomArr(int[] arr, int min, int max){
      Random rnd = new Random();

      for(int i=0;i<arr.Length;i++) 
          arr[i] = rnd.Next(min,max);

      return;
    }

      // Task 34
    static int Task_34(){
      int[] arr = new int[10];
      randomArr(arr,100,999);

      int res = 0;

      for(int i=0;i<arr.Length;i++){
        Console.Write(arr[i] + " ");
        res += (arr[i]%2) == 0?1:0;
      }

      Console.Write("\n");
      return res;
    }

      // Task 36
    static int Task_36(){
      int[] arr = new int[15];
      int res  = 0;

      randomArr(arr,-99,99);

      for(int i=0;i<arr.Length;i++){   // Я не понял позиция или индекс, но если счиать что 0-ой индекс это четный то так
          Console.Write(arr[i] + " ");
          if(i%2 != 0) res+=arr[i];
      }
      
       Console.Write("\n");

      return res;
    }

      // Task 38
    static double Task_38(){
      double[] arr = new double[10];
      double max,min;

      Random rand = new Random();
      for(int i=0;i<10;i++){
        arr[i] = Math.Round(rand.NextDouble() * 100,2);
      }

      max = min = arr[0];

      Console.Write(arr[0] + " ");

      for(int i=1;i<arr.Length;i++){
        Console.Write(arr[i] + " ");
        if(max < arr[i]) max = arr[i];
        else if(min>arr[i]) min = arr[i];
      }

      return max - min;
    }
    static void Main(){
      // Task 34
      Console.WriteLine("Task 34");
      Console.WriteLine("Res:= " + Task_34() + "\n");
      // Task 36
      Console.WriteLine("Task 36");
      Console.WriteLine("Res:= " + Task_36() + "\n");
      // Task 38
      Console.WriteLine("Task 38");
      Console.WriteLine("Res:= " + Task_38() + "\n");
    }
}
