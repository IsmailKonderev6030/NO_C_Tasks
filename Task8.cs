using System;
using System.Buffers;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

class Tasks{
    static int[,] randDArr(int n, int m, int min, int max){
        int[,] resArr = new int[n,m];
        var r = new Random();

        for(int i=0;i<n;i++)
            for(int j=0;j<m;j++)
                resArr[i,j] = r.Next(min,max);

        return resArr;
    }
    static void showDArr(int [,] dArr){
        for(int i=0;i<dArr.GetLength(0);i++){

            for(int j=0;j<dArr.GetLength(1);j++)
                Console.Write(dArr[i,j] + "\t");
            
            Console.Write("\n");
        }
    }
    static void insertSort(int[,] arr){
        if(arr.GetLength(0)==0) return;
        if(arr.GetLength(1) < 2) return;

        for(int i=0;i<arr.GetLength(0);i++){
            for(int j=1;j<arr.GetLength(1);j++){
                int temp = arr[i,j];
                int _j = j-1;

                while(_j>=0 && arr[i,_j] < temp) {
                    arr[i,_j+1] = arr[i,_j];
                    _j--;
                }
                arr[i,_j+1] = temp;
            }
        }
        return;
    }
    static int[,] mulMatrix(int[,] m1, int[,] m2){
        if(m1.GetLength(1) != m2.GetLength(0)){
            int[,] error = new int[1,1];
            error[0,0] = -1;
            return error;
        }   

        int[,]res = new int [m1.GetLength(0),m2.GetLength(1)];

        for(int i=0;i<m1.GetLength(0);i++){
            for(int a=0;a<m2.GetLength(1);a++){
                int temp=0;
                for(int j = 0;j<m1.GetLength(1);j++){
                    temp += m1[i,j] * m2[j,a];
                }
                res[i,a] = temp;
            }
        }

        return res;
    }

    // Task 54
    static void Task_54(){
        var r = new Random();
        int[,] dArr = randDArr(5,5,0,100);
        showDArr(dArr);
        Console.Write("\nBy sorted\n\n");
        insertSort(dArr);
        showDArr(dArr);
    }

    // Task 56
    static void Task_56(){
        int[,] dArr = randDArr(4,8,0,50);
        bool was = false;
        int[]res = new int[2]; // min == res[0] index == res[1]

        for(int i=0;i<4;i++){
            int temp = 0;
            for(int j=0;j<8;j++){
                temp += dArr[i,j];
            }

            if(!was) {
                res[0] = temp;
                res[1] = i;
                was = true;
            }
            else if(res[0] > temp){
                res[0] = temp;
                res[1] = i;
            }
        }
        showDArr(dArr);
        Console.WriteLine("min index:= " + res[1]);
    }
   
    // Task 58
    static void Task_58(){
        int[,] m1 = randDArr(3,3,1,10);
        int[,] m2 = randDArr(3,3,1,10);

        Console.WriteLine("First matrix:\n");
        showDArr(m1);
        Console.WriteLine("Second matrix:\n");
        showDArr(m2);

        Console.WriteLine("Res:=\n");
        int[,] res = mulMatrix(m1,m2);
        showDArr(res);
    }
    
    // Task 60
    static void Task_60(){
        int[,,] res = new int[3,3,3];
        int number = 10;

        // если делать ввывод отдельно то будет точно такой же цикл
        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                for(int a=0;a<3;a++){
                    res[i,j,a] = number++;
                    Console.WriteLine($"[{i}],[{j}],[{a}]:= {res[i,j,a]}");
                }
            }
        }
    }
    
    // Task 62
    static void Task_62(){
        int[,] res = new int[4,4];
        int step = 0; // 0 right 1 down 2 left 3 up
        int number = 1; // write to matrix
        int x = 0,y = 0;
        int maxX = 3, maxY = 3;
        int minX = 0, minY = 1;

        for(int i=0;i<16;i++){
            res[y,x] = number++;

            switch (step){
                case 0:
                    if(x<maxX) x++;
                    else{
                        maxX--;
                        step = 1;
                        y++;
                    } 
                    break;
                case 1:
                    if(y<maxY) y++;
                    else{
                        maxY--;
                        step = 2;
                        x--;
                    } 
                    break;
                case 2:
                    if(x>minX) x--;
                    else{
                        minX++;
                        step = 3;
                        y--;
                    }
                    break;
                case 3:
                    if(y>minY) y--;
                    else{
                        minY++;
                        step = 0;
                        x++;
                    } 
                    break;
            }
        }
        showDArr(res);
    }
    static void Main(){
        Console.WriteLine("\nTask 54");
        Task_54();
        
        Console.WriteLine("\nTask 56");
        Task_56();

        Console.WriteLine("\nTask 58");
        Task_58();

        Console.WriteLine("\nTask 60");
        Task_60();

        Console.WriteLine("\nTask 62");
        Task_62();
    }
}
