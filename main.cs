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
string[] result = new string[count];  // создаем новый массив нужной длины 

count = 0;  // обнуляем счетчик 
for (int i = 0; i < input.Length; i++) 
{ 
if (input[i].Length <= 3) 
{ 
result[count] = input[i];  // добавляем строку в новый массив 
count++; 
} 
} 

return result; 
} 
} 