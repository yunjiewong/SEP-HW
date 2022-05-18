// See https://aka.ms/new-console-template for more information
using Assignment2;
using System.Text;


// CopyArray ca = new CopyArray();
// Console.WriteLine();

// int[] ans = FindPrime.FindPrimesInRange(3, 11);
// Array.ForEach(ans, Console.WriteLine);


// LongestSequence lo = new LongestSequence();

// int[] num = {1,1,1,2,3,1,3,3};
// int[] an = lo.Longest(num);
// foreach (int i in an){
//     Console.Write(i + " ");
// }
// int[] num2 ={7, 7,7 ,0 ,2 ,2, 2, 0, 10 ,10 ,10};
// MostFrequent mf =new MostFrequent(num2);



// RotationArray ra = new RotationArray();
// int[] i= {3,2 ,4, -1};
// ra.rotateArrayAndSum(i, 2); 


// Parsing p = new Parsing();
char ch =' ';
Console.WriteLine(Char.IsPunctuation(ch) );
Console.WriteLine(Char.IsPunctuation(ch) );

string s ="Hi,exe? ABBA! Hog fully a string: ExE. Bob";
string output = new string(s.Where(c => !char.IsPunctuation(c)).ToArray());
Console.WriteLine(output);

Console.WriteLine();


AllPalindrome ap = new AllPalindrome(s);
