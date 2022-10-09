using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;

namespace DivEduTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conditions
            //Task1:
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a>b)
            //{
            //    Console.WriteLine(a+b);
            //}
            //else if(a==b)
            //{
            //    Console.WriteLine(a * b);
            //}
            //else if(a<b)
            //{
            //    Console.WriteLine(a - b);
            //}

            //Task2
            //int x= Convert.ToInt32(Console.ReadLine());
            //int y= Convert.ToInt32(Console.ReadLine());
            //if (x>0 && y>0)
            //{
            //    Console.WriteLine("Quadrant1,Top right");
            //}
            //else  if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("Quadrant2,Bottom right");
            //}
            //else if (x <0 && y < 0)
            //{
            //    Console.WriteLine("Quadrant3,Bottom left");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("Quadrant4,Top left");
            //}

            //Task3:
            //int[] Array = new int[] {};
            //int temp = 0;
            //for (int i = 0; i <= Array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < Array.Length; j++)
            //    {
            //        if (Array[i] > Array[j])
            //        {
            //            temp = Array[i];
            //            Array[i] = Array[j];
            //            Array[j] = temp;
            //        }
            //    }
            //}
            //foreach (var item in Array)
            //{
            //    Console.WriteLine(item);
            //}

            //Task4:
            //double discriminant = b * b - 4 * a * c;
            //if (discriminant>0)
            //{
            //    double x1 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            //    double x2 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            //    Console.WriteLine(x1);
            //    Console.WriteLine(x2);
            //}
            //else
            //{
            //    Console.WriteLine("discriminant is minus");
            //}

            //Task6:
            //int r = Convert.ToInt32(Console.ReadLine());
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //double distance = Math.Sqrt(x * x + y * y);
            //if (distance > r)
            //{
            //    Console.WriteLine("outside");
            //}
            //else if (distance<r)
            //{
            //    Console.WriteLine("inside");
            //}
            //else
            //{
            //    Console.WriteLine("over");
            //}

            //Task7:

            //a
            //int sum = 0;
            //while (a>0)
            //{
            //    int rest=a % 10;
            //    a=a/10;
            //    sum+=rest;
            //}
            //Console.WriteLine(sum);
            //if (a*a==Math.Pow(sum,3))
            //{
            //    Console.WriteLine("sum is equal all digits to the power 3");
            //}
            //else
            //{
            //    Console.WriteLine("sum is not equal all digits to the power 3");
            //}

            //b
            //int count = 0;
            //int sum = 0;
            //int lastDigits = 0;
            //while (a > 0)
            //{
            //    int rest = a % 10;
            //    a = a / 10;
            //    sum += rest;
            //    count++;
            //    if (count == 2)
            //    {
            //        lastDigits = sum;
            //    }
            //}
            //if (lastDigits == sum - lastDigits)
            //{
            //    Console.WriteLine("equal");
            //}
            //else
            //{
            //    Console.WriteLine("not equal");
            //}

            //c 
            //int[] arr = new int[3];
            //int i = 0;
            //bool check = false;
            //while (a > 0)
            //{
            //    int rest = a % 10;
            //    a /= 10;
            //    arr[i] = rest;
            //    i++;
            //}

            //for (int k = 0; k < arr.Length; k++)
            //{
            //    for (int j = k + 1; j < arr.Length; j++)
            //    {
            //        if (arr[k] == arr[j])
            //        {
            //            check = true;
            //        }
            //    }
            //}
            //if (check)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            //d !!!
            //double number = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(number);
            //string[] digits = number.ToString().Split(',');
            //foreach (var item in digits)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion
            #region Cycles
            //Tasks1:
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i <b; i++)
            //{
            //    result *=a ;
            //}
            //Console.WriteLine(result);

            //Task2:
            //int count = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i%a==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //Task3:
            //for (int i = 0; i < a; i++)
            //{
            //    if (i*i<a)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Task4:
            //int largDiv = 0;
            //for (int i = 1; i < a; i++)
            //{
            //    if (a%i==0)
            //    {
            //        largDiv = i;
            //    }
            //}
            //Console.WriteLine(largDiv);

            //Task5:
            //int sum =0;
            //if (a < b)
            //{
            //    for (int i = a; i < b; i++)
            //    {
            //        if (i % 7 == 0)
            //        {
            //            sum += i;
            //        }
            //    }
            //}
            //else if(a>b)
            //{
            //    for (int i = b; i< a; i++)
            //    {
            //        if (i % 7 == 0)
            //        {
            //            sum += i;
            //        }
            //    }
            //}
            //Console.WriteLine(sum);

            //Task6:
            //int num1 = 1;
            //int num2 = 1;

            //int[] fibonacciNum = new int[5] ;
            //fibonacciNum[0] = num1;
            //fibonacciNum[1] = num2;
            //for (int i = 2; i < fibonacciNum.Length; i++)
            //{

            //    fibonacciNum[i] = num1 + num2;//2 2 3 5
            //    num1 = fibonacciNum[i - 1]; 
            //    num2 = fibonacciNum[i];
            //    //Console.WriteLine(fibonacciNum[i]);
            //    if (a == i)
            //    { 
            //        Console.WriteLine(fibonacciNum[a]);
            //    }
            //}

            //Task8:
            //for (int i = 0; i < a; i++)
            //{
            //    if (i * i * i == a)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}

            //Task9:
            //int count = 0;
            //while (a > 0)
            //{
            //   int digit= a % 10;
            //    a /= 10;
            //    if (digit % 2!=0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //Task10:
            //int mirror = 0;
            //while (a > 0)
            //{
            //    mirror =(mirror*10)+ a % 10;
            //    a /= 10;
            //}
            //Console.WriteLine(mirror);

            //Task11:
            //int sumOfEven = 0;
            //int sumOfOdd = 0;
            //for (int i = 15; i < a; i++)
            //{
            //    int temp = i;
            //    while (temp > 0)
            //    {
            //        int digit = temp % 10;
            //        temp /= 10;
            //        if (digit % 2 == 0)
            //        {
            //            sumOfEven += digit;
            //        }
            //        else
            //        {
            //            sumOfOdd += digit;
            //        }
            //    }
            //    if (sumOfEven > sumOfOdd)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    sumOfEven = 0;
            //    sumOfOdd = 0;
            //}

            //Task12:

            #endregion
            #region Arrays
            //Task1:
            //int[] arr = new int[] {3,9,1,2,22,0};
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]<min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine(min);

            //Task2:
            //int[] arr = new int[] { 3, 9, 1, 2, 22, 222,0 };
            //int max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if ( max<arr[i])
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(max);

            //Task3:
            //int[] arr = new int[] { -2,-77,3, 9, 1, 2, 22, 0 };
            //int min = arr[0];
            //int minIndex = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //        minIndex = i;
            //    }
            //}
            //Console.WriteLine(minIndex);

            //Task4:
            //int[] arr = new int[] { -2, -77, 3, 9, 1, 2, 22, 0 };
            //int max = arr[0];
            //int maxIndex = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //        maxIndex = i;
            //    }
            //}
            //Console.WriteLine(maxIndex);

            //Task5:
            //int[] arr = new int[] { 3, 9, 1, 2, 22, 0,12,20 };
            //int sumofOddIndexs = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i%2!=0)
            //    {
            //        sumofOddIndexs += arr[i];
            //    }
            //}
            //Console.WriteLine(sumofOddIndexs);

            //Task6:
            //int[] arr = new int[] { 3, 9, 1, 2 };
            //for (int i = 0; i < arr.Length/2; i++)
            //{
            //    int temp = arr[i];
            //    arr[i] = arr[arr.Length - i - 1];
            //    arr[arr.Length - i - 1] = temp;
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Task7:
            //int[] arr = new int[] { 3, 9, 1, 2 ,13,5,73};
            //int count = 0;n
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]%2!=0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            //Task8:
            //int[] arr = new int[] { 3, 9, 1, 2,5,2 };
            //int halfLength = arr.Length / 2;
            //if (arr.Length % 2 == 1)
            //{
            //    for (int i = 0; i < halfLength; i++)
            //    {
            //        int temp = arr[i];
            //        arr[i] = arr[halfLength + i + 1];
            //        arr[halfLength + i + 1] = temp;
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < halfLength; i++)
            //    {
            //        int temp = arr[i];
            //        arr[i] = arr[halfLength + i];
            //        arr[halfLength + i] = temp;
            //    }
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item );
            //}

            //Task9:
            //int[] arr = new int[] { 3, -2, 1, 2, 5 };
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[i])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2DArrays
            //Task1,2,3,4:
            const int x = 3, y = 5;
            int[,] arr = new int[x, y] { { -10, 50, 13, 80, 40 }, { 1, 250, 65, 28, 15 }, { 12, 17, 45, 20, 6 } };
            int min = arr[0, 0];
            int max = arr[0, 0];
            int minIndex = 0;
            int maxIndex = 0;
            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        //firstIndex = i;
                        //secondIndex = j;
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        firstIndex = i;
                        secondIndex = j;

                    }
                }
            }
            Console.WriteLine("Min value: " + min);
            Console.WriteLine("Max value: " + max);
            Console.WriteLine($"[{firstIndex}, {secondIndex}]");




            #endregion


        }
    }
}