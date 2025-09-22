//Exercise 1 

//int number = 0;

//void NumberList(int n)
//{
//    if (number <= n)
//    {
//        Console.WriteLine(number);
//        number = number + 1;
//        NumberList(n);
//    }
//    else
//        number = 0;
//}

//NumberList(7);



//Exercise 2 

//int[] x = [2, 3, 7, 20, 37, 51];
//int y = 0, z = 0;

//void AddingNumbers(int[] x)
//{
//    if (z <= (x.Length - 1))
//    {
//        y = y + x[z];
//        z = z + 1;
//        AddingNumbers(x);
//    }
//    else
//        Console.WriteLine(y);
//}

//AddingNumbers(x);



//Exercise 3

//int x = 1, y = 0;

//void AddingNumbersFromOne(int n)
//{
//    if (x <= n)
//    {
//        y = y + x;
//        x = x + 1;
//        AddingNumbersFromOne(n);
//    }
//    else
//        Console.WriteLine(y);
//}

//AddingNumbersFromOne(7);





//Exercise 4

//int number = -2;
//string invertedWord = "";

//void Reverse(string word)
//{
//    if (number == -2)
//    {
//        number = word.Length - 1;
//        Reverse(word);
//    }
//    else if (number >= 0)
//    {
//        invertedWord = invertedWord + word[number];
//        number = number - 1;
//        Reverse(word);
//    }
//    else
//        Console.WriteLine(invertedWord);
//}

//Reverse("Hey :)");





//Exercise 5

//int number = 1, x = 1;
//void Factorial(int n)
//{
//    if (number <= n)
//    {
//        x *= number;
//        number = number + 1;
//        Factorial(n);
//    }
//    else
//        Console.WriteLine(x);
//}

//Factorial(7);





//Exercise 6


//Exercise 7 

//int[] x = [0, 0, 0, 1];
//int z = 0, y = 0;


//void TetanacciSequence(int n)
//{
//    if ((z + 1) <= (n - 4))
//    {
//        y = x[z] + x[z + 1] + x[z + 2] + x[z + 3];
//        x = x.Append(y).ToArray();
//        z = z + 1;
//        TetanacciSequence(n);
//    }
//    else
//        Console.WriteLine(y);
//}

//TetanacciSequence(10);





//Exercise 8

//int y = 1, x = 0;

//void RecursiveSumCubes(int n)
//{
//    if (y <= n)
//    {
//        x += (int)Math.Pow(y, 3);
//        y = y + 1;
//        RecursiveSumCubes(n);
//    }
//    else
//        Console.WriteLine(x);
//}

//RecursiveSumCubes(3);





//Exercise 9

//int number = 0;

//void RecursiveSum(int n)
//{
//    if (n > 0)
//    {
//        number += (n % 10);
//        n = n / 10;
//        RecursiveSum(n);
//    }
//    else
//        Console.WriteLine(number);
//}

//RecursiveSum(587);





//Exercise 10

//int[] x = [0, 1];
//int y = 2;

//void PellSequence(int n)
//{
//    if (n > 1)
//    {
//        if (y <= n)
//        {
//            x = x.Append(2 * x[y - 1] + x[y - 2]).ToArray();
//            y = y + 1;
//            PellSequence(n);
//        }
//        else
//            Console.WriteLine(x[n]);
//    }
//    else
//        Console.WriteLine(n);
//}

//PellSequence(7);



