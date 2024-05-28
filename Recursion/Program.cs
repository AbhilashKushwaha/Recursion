using System;
using System.Collections;
using System.Collections.Generic;

namespace Recursion
{
    public class Program
    {
        public void PrintNumberAsc(int N)
        {
            if (N > 0)
            {
                PrintNumberAsc(N - 1);
                Console.WriteLine(N);
            }
        }

        public void PrintNumberDec(int N)
        {
            if (N > 0)
            {
                Console.WriteLine(N);
                PrintNumberAsc(N - 1);
            }
        }

        public int PrintMean(int[] arr, int index)
        {
            if (index <= 0)
            {
                return 0;
            }
            else
            {
                return (PrintMean(arr, index - 1) + arr[index - 1]);
            }

        }

        public int PrintSumNaturalNum(int N)
        {
            if (N <= 0)
            {
                return 0;
            }
            else
            {
                return (PrintSumNaturalNum(N - 1) + N);
            }

        }

        string binarynum = string.Empty;
        public void PrintBinary(int N)
        {
            if (N <= 1)
            {
                binarynum += 1;
            }
            else
            {
                PrintBinary(N / 2);

                if (N % 2 == 0)
                {
                    binarynum += 0;
                }
                else
                {
                    binarynum += 1;
                }
            }

        }

        string stringReverse = string.Empty;
        public string PrintStringReverse(string str)
        {
            if (str.Length - 1 == 0)
            {
                return str[0].ToString();
            }
            else
            {
                stringReverse += str[str.Length - 1].ToString() + PrintStringReverse(str.Substring(0, str.Length - 1));
                return stringReverse;
            }

        }

        public int PrintStringLengthRec(string str)
        {
            if (str == "")
            {
                return 0;
            }
            else
            {
                return PrintStringLengthRec(str.Substring(1)) + 1;
            }

        }

        public int PrintSumOfDigit(int num)
        {
            if (num % 10 == 0)
            {
                return 0;
            }
            else
            {
                return num % 10 + PrintSumOfDigit(num / 10);
            }

        }

        public void PrintFibonacci(int N, int first, int second)
        {
            if (first == 0)
            {
                Console.WriteLine(first);
                Console.WriteLine(second);
            }
            if (second <= N)
            {
                Console.WriteLine(first + second);
                PrintFibonacci(N, second, first + second);
            }

        }

        public int PrintFactorial(int N)
        {
            if (N == 0)
            {
                return 1;
            }
            else
            {
                var result = N * PrintFactorial(N - 1);
                return result;
            }

        }

        public void PrintMaxMin(int[] arr, int index, int min, int max)
        {
            if (index < 0)
            {
                Console.WriteLine($"Max = {max} Min = {min}");
            }
            else
            {
                //Math.Min(arr[index], PrintMaxMin(arr, index - 1);
                if (arr[index] > max) { max = arr[index]; }
                if (arr[index] < min) { min = arr[index]; }
                PrintMaxMin(arr, index - 1, min, max);
            }

        }

        public string revstr = string.Empty;
        public string PrintIsPanindrom(string str)
        {
            if (str.Length == 0)
            {
                return "";
            }
            else
            {
                revstr += str[str.Length - 1].ToString() + PrintIsPanindrom(str.Substring(0, str.Length - 1));
            }
            return revstr;
        }

        public int bitcount = 0;
        public void PrintBinaryBitCount(int N)
        {
            if (N <= 1)
            {
                bitcount++;
            }
            else
            {
                if (N % 2 != 0)
                {
                    bitcount++;
                }

                PrintBinaryBitCount(N / 2);

            }
        }

        public int counter = 0;
        public void PrintRevFibanocci(int N, int first, int second)
        {
            counter++;
            if (counter == N)
            {
                Console.WriteLine(first + second);
            }
            else
            {
                PrintRevFibanocci(N, second, first + second);

                if (first == 0)
                {
                    Console.WriteLine(second);
                    Console.WriteLine(first);
                }
                else if (first == 1)
                {
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine(first + second);
                }
            }
        }


        public int PrintCoinChange(int[] coins, int availableCoins, int target)
        {
            if (target == 0)
            {
                return 1;
            }

            if (target < 0)
            {
                return 0;
            }

            if (availableCoins < 0)
            {
                return 0;
            }

            return PrintCoinChange(coins, availableCoins - 1, target) + PrintCoinChange(coins, availableCoins, (target - coins[availableCoins]));
        }

        public void PrintStringPermutaion(string str, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    str = Swap(str, left, i);
                    PrintStringPermutaion(str, left + 1, right);
                }
            }
        }

        private string Swap(string str, int left, int i)
        {
            char[] charArr = str.ToCharArray();
            char temp;
            temp = charArr[left];
            charArr[left] = str[i];
            charArr[i] = temp;
            string s = new string(charArr);
            return s;
        }

        public int LongestCommonSubsequence(string S1, string S2, int m, int n)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }
            else
            {
                if (S1[m - 1] == S2[n - 1])
                {
                    return 1 + LongestCommonSubsequence(S1, S2, m - 1, n - 1);
                }
                else
                {
                    return MaxResult(LongestCommonSubsequence(S1, S2, m, n - 1), LongestCommonSubsequence(S1, S2, m - 1, n));
                }
            }
        }

        private int MaxResult(int v1, int v2)
        {
            return v1 > v2 ? v1 : v2;
        }

        public class Node
        {
            public int key;
            public Node left;
            public Node right;
            public Node(int num)
            {
                key = num;
                left = null;
                right = null;
            }
        }

        public class BinaryTree
        {
            Node root;
            public BinaryTree()
            {
                root = null;
            }

            public void PrintInorder(Node node)
            {
                if (node == null)
                {
                    return;
                }

                PrintInorder(node.left);
                Console.WriteLine(node.key + " ");
                PrintInorder(node.right);
            }


            public void PrintPreorder(Node node)
            {
                if (node == null)
                {
                    return;
                }

                Console.WriteLine(node.key + " ");
                PrintPreorder(node.left);

                PrintPreorder(node.right);
            }

            public void PrintPostorder(Node node)
            {
                if (node == null)
                {
                    return;
                }

                PrintPostorder(node.left);

                PrintPostorder(node.right);

                Console.WriteLine(node.key + " ");
            }
        }

        public IEnumerable<int> Series(int n)
        {
            for (int i = 0, pi = 2, ci = 1; i < n; i++)
            {
                yield return pi;
                int ni = (ci % 2 == 0) ? pi + ci : pi - ci;
                pi = ci;
                ci = ni;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program printnumber = new Program();

            //printnumber.PrintNumberAsc(10);

            //printnumber.PrintNumberDec(10);

            //int[] arr = { 1, 2, 3, 4, 5 };
            //var sum = printnumber.PrintMean(arr, arr.Length);
            //var mean = sum / arr.Length;
            //Console.WriteLine($"Mean = {mean}");

            //var sumNatural = printnumber.PrintSumNaturalNum(6);
            //Console.WriteLine($"sumNatural = {sumNatural}");

            //printnumber.PrintBinary(100);
            //Console.WriteLine($"PrintBinary = {printnumber.binarynum}");

            //string str = "My Name is Abhilash";
            //var stringReverseTest =  printnumber.PrintStringReverse(str);
            //Console.WriteLine($"PrintStringReverse = {stringReverseTest}");

            //string str = "My Name is Abhilash";
            //var strLength = printnumber.PrintStringLengthRec(str);
            //Console.WriteLine($"strLength = {strLength}");

            //var SumOfDigit = printnumber.PrintSumOfDigit(45632);
            //Console.WriteLine($"SumOfDigit = {SumOfDigit}");

            // printnumber.PrintFibonacci(10, 0, 1);

            //var fact = printnumber.PrintFactorial(10);
            //Console.WriteLine($"PrintFactorial = {fact}");

            //int[] arr = { 1, 2, 3, 4, 5 };
            //printnumber.PrintMaxMin(arr, arr.Length-1, arr[0],arr[0]);

            //string str = "1malayalam1";
            //var stringIsPanindrom =  printnumber.PrintIsPanindrom(str);
            //if (stringIsPanindrom == str)
            //{
            //    Console.WriteLine($"IsPanindrom = {true}");
            //}
            //else
            //{
            //    Console.WriteLine($"IsPanindrom = {false}");
            //}

            //printnumber.PrintBinaryBitCount(21);
            //Console.WriteLine($"PrintBinaryBitCount = {printnumber.bitcount}");


            //printnumber.PrintRevFibanocci(10, 0, 1);

            //int sum = 4;
            //int[] coins = { 1, 2, 3 };
            //var coinChange = printnumber.PrintCoinChange(coins, coins.Length-1, sum);
            //Console.WriteLine($"coinChange set = {coinChange}");

            //printnumber.PrintStringPermutaion("ABC",0, "ABC".Length-1);
            //String S1 = "AGGTAB";
            //String S2 = "GXTXAYB";

            //int LCS= printnumber.LongestCommonSubsequence(S1, S2, S1.Length,S2.Length);
            //Console.WriteLine($"LongestCommonSubsequence = {LCS}");

            //BinaryTree tree = new BinaryTree(); 
            //Node rootnode = new Node(1);
            //rootnode.left = new Node(2);
            //rootnode.right = new Node(3);

            //rootnode.left.left = new Node(4);
            //rootnode.left.right = new Node(5);
            //tree.PrintInorder(rootnode);
            //Console.WriteLine("---------------");
            //tree.PrintPreorder(rootnode);
            //Console.WriteLine("---------------");
            //tree.PrintPostorder(rootnode);

            //foreach (var item in printnumber.Series(6))
            //{
            //    Console.WriteLine(item + " ");
            //}

        }
    }
}
