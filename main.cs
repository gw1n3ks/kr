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
static string[] FilterArray(string[] input) 
{ 
int count = 0; 
for (int i = 0; i < input.Length; i++) 
{ 
if (input[i].Length <= 3)  // проверяем длину строки 
{ 
count++;  // увеличиваем счетчик 
} 
} 