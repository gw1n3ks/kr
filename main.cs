csharp 
using System; 

class Program 
{ 
static void Main() 
{ 
string[] inputArray = new string[] { "Hello", "2", "world", ":-)" }; 
string[] resultArray = FilterArray(inputArray); 

foreach (var item in resultArray) 
{ 
Console.Write(item + " "); 
} 
} 