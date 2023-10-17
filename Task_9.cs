using System;

public class Answer
{
    static void Task_64(int N){
        if(N == 0) return;
        Console.Write(N + " ");
        Task_64(N-1);
    }
    static int Task_66(int M, int N){
        if(M>=N) return M;
        return Task_66(M+1,N) + M;
    }

    static int Task_68(int m, int n)
    {
        if (m == 0) return n + 1;
        else if ((m != 0) && (n == 0)) return Task_68(m - 1, 1);
        else return Task_68(m - 1, Task_68(m, n - 1));
    }
    public static void Main(string[] args)
    {   
        Console.WriteLine("Task 64");
        Task_64(5);
        Console.WriteLine("\nTask 66");
        Console.WriteLine(Task_66(4,8));
        Console.WriteLine("\nTask 68");
        Console.WriteLine(Task_68(2,3));

        return;
    }
}
