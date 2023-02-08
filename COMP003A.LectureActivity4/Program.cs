/* 
*  Author: Jonathan Cruz
*  Course: COMP-003A
4    *  Purpose: Code for Lecture Activity 4
5    *  Reference: 
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-
statements
6    */
7
8   namespace COMP003A.LectureActivity4
9   {
10   internal class Program
11   {
12   static void Main(string[] args)
13   {
14   Console.WriteLine("".PadRight(50, '*'));
15   Console.WriteLine("for-loop statement");
16   Console.WriteLine("".PadRight(50, '*'));
17   
18   // count 0-9
19   int limit = 10; // variable limit for the loop
20   /*
21                * The for statement: executes its body while a specified Boolean expression 
evaluates to true.
22                * there are 3 parts in the for loop statement
23                * 1. int counter = 0; => loop variable initialization
24                * 2. counter < limit; => condition
25                * 3. counter++ => iterator
26               */
27   for (int counter = 0; counter<limit; counter++)
28   {
29   // this code block will execute every loop
30   Console.WriteLine($"\tCurrent counter: {counter}");
31   }
32
33   Console.WriteLine("\n"); // new line
34   Console.WriteLine("".PadRight(50, '*'));
35   Console.WriteLine("foreach statement");
36   Console.WriteLine("".PadRight(50, '*'));
37
38   // this is a simple array with 10 items in it. you will learn more about 
arrays on module 7
39   string[] simpleArray = new string[] { "eleifend", "donec", "pretium",
"vulputate", "sapien", "nec", "sagittis", "aliquam", "malesuada", "bibendum"
};
40
41   // enumerates the elements of a collection and executes its body for each 
element of the collection
42   foreach (var item in simpleArray)
43   {
    44   Console.WriteLine($"\tCurrent item: {item}");
    45   }
46
47   Console.WriteLine("\n"); // new line
48   Console.WriteLine("".PadRight(50, '*'));
49   Console.WriteLine("do-while statement");
50   Console.WriteLine("".PadRight(50, '*'));
51
52   /* 
53                * The do statement executes a statement or a block of statements while a 
specified
54                * Boolean expression evaluates to true. Because that expression is 
evaluated after
55                * each execution of the loop, a do loop executes one or more times. The do 
56                * statement differs from a while loop, which executes zero or more times.
57               */
58
59   int counter2 = 0; // initial counter2 value
60
61   do
    62   {
    63   Console.WriteLine($"\tCurrent counter2: {counter2}");
    64   counter2++; // increment counter2 by 1
    65   } while (counter2 < 10) ; // loop until counter2 is equal to 10 or greater
66
67
68   Console.WriteLine("\n"); // new line
69   Console.WriteLine("".PadRight(50, '*'));
70   Console.WriteLine("while statement");
71   Console.WriteLine("".PadRight(50, '*'));
72
73   /* 
74                * The while statement executes a statement or a block of statements while a 
specified
75                * Boolean expression evaluates to true. Because that expression is 
evaluated before 
76                * each execution of the loop, a while loop executes zero or more times. The 
while 
77                * statement differs from a do loop, which executes one or more times.
78               */
79
80   int counter3 = 0; // initial counter3 value;
81
82   while (counter3 < 20)
    83   {
    84   Console.WriteLine($"\tCurrent counter3: {counter3}");
    85   counter3 += 2; // add 2 to the value of counter3
    86   }
87
88   Console.WriteLine("\n"); // new line
89   Console.WriteLine("".PadRight(50, '*'));
90   Console.WriteLine("example for loop program that counter from 1-20 and 
checks if it is odd or even");
91   Console.WriteLine("".PadRight(50, '*'));
92
93   // 1. loop variable 'i' is set 1 instead of 0
94   // 2. loop as long as the loop variable is less than or equal to 20
95   // 3. increment the loop variable by 1
96   for (int i = 1; i <= 20; i++)
    97   {
    98   if (i % 2 == 0)
        99   {
        100   Console.WriteLine($"\t{i}: even");
        101   }
    102   else
        103   {
        104   Console.WriteLine($"\t{i}: odd");
        105   }
    106   }
107   }
108   }
109   }