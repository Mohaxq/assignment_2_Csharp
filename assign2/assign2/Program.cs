namespace assign2
{
    internal class Program
    {
       static bool isprime(int n)
        {
            if(n<=1) return false;
            for(int i=2;i*i<=n;i++)
            {
                if(n%i==0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            //1
            /*Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            if(num%3==0 && num % 4 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("NO");
            }*/

            //2
            /*Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            if(num<0) Console.WriteLine("negative");
            else if (num > 0) Console.WriteLine("positive");
            else Console.WriteLine("zero");*/

            //3
            /*Console.WriteLine("enter 3 numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int mx = -1;
            int mn = int.MaxValue;
            if (num1 > num2 && num1 > num3) mx = num1;
            else if (num2 > num1 && num2 > num3) mx = num2;
            else if (num3 > num1 && num3 > num2) mx = num3;

            if (num2 < num1 && num2 < num3) mn = num2;
            else if (num1 < num2 && num1 < num3) mn = num1;
            else if (num3 < num1 && num3 < num2) mn = num3;
            Console.WriteLine("max element "+mx);
            Console.WriteLine("min element "+mn);*/

            //4
            /* Console.WriteLine("enter number: ");
             int num = int.Parse(Console.ReadLine());
             if (num % 2 == 0) Console.WriteLine("even");
             else Console.WriteLine("odd");*/

            //5
            /*Console.WriteLine("enter char: ");
            char ch = char.Parse(Console.ReadLine());
            if(ch=='a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }*/

            //6
            /*Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
               Console.WriteLine(i);
            }*/

            //7
            /*Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1;i<=12;i++)
            {
                Console.WriteLine(i*num);
            }*/

            //8
            /* Console.WriteLine("enter number: ");
             int num = int.Parse(Console.ReadLine());
             for (int i = 1; i <= num; i++)
             {
                 if (i % 2 == 0) Console.WriteLine(i);
             }*/

            //9
            /* Console.WriteLine("enter number: ");
             int num = int.Parse(Console.ReadLine());
             Console.WriteLine("enter the power: ");
             int p = int.Parse(Console.ReadLine());
             int x = num;
             for(int i = 1;i<=p-1;i++)
             { 
                 num *= x;
             }
             Console.WriteLine(num);*/

            //10
            /* Console.WriteLine("enter five degrees of subjects: ");
             int sum = 0;
             int avg = 0;
             int pers = 0;
             for(int i = 0; i < 5; i++)
             {
                 int x = int.Parse(Console.ReadLine());
                 sum += x;
             }
             avg = sum / 5;
             pers = (sum * 100) / 500;
             Console.WriteLine("sum= " + sum);
             Console.WriteLine("average= " + avg);
             Console.WriteLine("percentage= " + pers);
            */

            //11
            /*Console.Write("Enter month number (1-12): ");
            int monthNumber = int.Parse(Console.ReadLine());
                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    int daysInMonth;
                    if (monthNumber == 2)
                    {
                        daysInMonth = 28;
                        Console.WriteLine($"{daysInMonth}");
                    }
                    else if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 ||
                             monthNumber == 7 || monthNumber == 8 || monthNumber == 10 ||
                             monthNumber == 12)
                    {
                        daysInMonth = 31;
                        Console.WriteLine($"{daysInMonth}");
                    }
                    else
                    {
                        daysInMonth = 30;
                        Console.WriteLine($"{daysInMonth}");
                    }
                }*/

            //12
            // simple calculator
            /*Console.WriteLine("enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter operator (+,-,*,/): ");
            char op = char.Parse(Console.ReadLine());
            if(op=='+')
            {
                Console.WriteLine(num1 + num2);
            }
            else if(op=='-')
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == '*')
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == '/')
            {
                Console.WriteLine(num1 / num2);
            }*/

            //13
            /*Console.WriteLine("enter string: ");
            string str = Console.ReadLine();
            for(int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }*/

            //14
            /*Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            string rev = "";
            while(num>0)
            {
                int r = num % 10;
                rev += r;
                num /= 10;
            }
            Console.WriteLine(rev);*/

            //15
            /*Console.WriteLine("enter start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter end number: ");
            int end = int.Parse(Console.ReadLine());
            for(int i = start; i <= end; i++)
            {
                if(isprime(i))
                {
                    Console.WriteLine(i);
                }
            }*/

            //16
            /*Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            int x = num;
            string bin = "";
            while(num>0){
                int r = num % 2;
                bin = r + bin;
                num /= 2;
            }
            Console.WriteLine($"binary number for {x} is {bin}");*/

            //17
            /*Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());

            
            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            
            Console.Write("Enter x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Enter y3: ");
            double y3 = double.Parse(Console.ReadLine());

            double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            if( Math.Abs(area) < 1e-10)
            {
                Console.WriteLine("The points are collinear.");
            }
            else
            {
                Console.WriteLine("The points are not collinear.");
            }*/

            //18
            /*Console.WriteLine("enter the hours for task: ");
            int hours = int.Parse(Console.ReadLine());
            if(hours>=2 && hours<=3) Console.WriteLine("great");
            else if (hours > 3 && hours <= 4) Console.WriteLine("good");
            else if(hours>4 && hours<=5) Console.WriteLine("fair");
            else if(hours>5) Console.WriteLine("leave");*/

            //19
            /*Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            int[,] arr = new int[num,num];
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    if (j == i) arr[i,j] = 1;
                    else arr[i,j] = 0;
                }
            }
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }*/

            //20
            /*Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int sum = 0;
            for(int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("sum = "+sum);*/

            //21
            /* Console.WriteLine("enter number: ");
             int num = int.Parse(Console.ReadLine());
             int[] arr = new int[num];
             int[] arr2 = new int[num];
             int[] arr3 = new int[num*2];
             for (int i = 0; i < num; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
             }
             for (int i = 0; i < num; i++)
             {
                 arr2[i] = int.Parse(Console.ReadLine());
             }
             for (int i = 0; i < num; i++)
             {
                 arr3[i] = arr[i];
             }
             for (int i = 0; i < num; i++)
             {
                 arr3[i+num] = arr2[i];
             }
             Array.Sort(arr3);
             for (int i = 0; i < num*2; i++)
             {
                 Console.Write(arr3[i]+" ");
             }*/

            //22
            /*Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int[] freq = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                freq[arr[i]]++;
            }
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(freq[i]);
            }*/

            //23
            /* Console.WriteLine("enter number: ");
             int num = int.Parse(Console.ReadLine());
             int[] arr = new int[num];
             int mx = int.MinValue;
             int mn = int.MaxValue;
             for (int i = 0; i < num; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
                 if (arr[i] > mx) mx = arr[i];
                 if (arr[i] < mn) mn = arr[i];
             }
             Console.WriteLine("max = " + mx);
             Console.WriteLine("min = " + mn);*/

            //24
            /* Console.WriteLine("enter number: ");
             int num = int.Parse(Console.ReadLine());
             int[] arr = new int[num];
             for (int i = 0; i < num; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
             }
             Array.Sort(arr);
             Console.WriteLine(arr[num-2]);*/

            //25
            /* Console.WriteLine("enter number: ");
             int num = int.Parse(Console.ReadLine());
             int[] arr = new int[num];
             for (int i = 0; i < num; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
             }
             int maxdist = -1;
             for(int i = 0; i < num; i++)
             {
                 for(int j = num-1; j>i; j--)
                 {
                     if(arr[i]==arr[j])
                     {
                         int dist = j - i-1;
                         if (dist > maxdist) maxdist = dist;
                     }
                 }
             }
             Console.WriteLine(maxdist);*/

            //26
            /*Console.WriteLine("enter sentence: ");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            Array.Reverse(words);
            foreach(string w in words)
            {
                Console.Write(w+" ");
            }*/

            //27
            /*Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = num-1; i >=0; i--)
            {
                Console.Write(arr[i]+" ");
            }*/


        }

    }
}
