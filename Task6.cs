using System;
using System.Buffers;

class Tasks{

    // Task 41
    static int Task_41(){
        int res=0;

        Console.Write("Введите кол-во элементов: ");
        int size = Convert.ToInt32(Console.ReadLine());
        
        int[] arr = new int[size];

        for(int i=0;i<size;i++){
            Console.Write("Введите " + (i+1) + " элемент: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if(arr[i]>0) res++;
        }

        return res;
    }

    // Task 43
    static void Task_43(){
        double[]res = new double[2];

        double b1,b2;
        double k1,k2;

        Console.Write("Введите b1: ");
        b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k1: ");
        k1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n");

        Console.Write("Введите b2: ");
        b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k2: ");
        k2 = Convert.ToDouble(Console.ReadLine());

        if(b1 == b2)
            if (b2 == k2) Console.WriteLine("Прямые совпадают");
            else          Console.WriteLine("Прямые паралленльны");
        else{
            double c1 = (b1 - b2) / (k2 - k1);
            double c2 = k2 * c1 + b2;

            Console.WriteLine(c1 + ", " + c2);
        }

        return;
    }
    static void Main(){
        Console.WriteLine("Task 41");
        Console.WriteLine("Res:= " + Task_41() + "\n");

        Console.WriteLine("Task 43");
        Task_43();
    }
}
