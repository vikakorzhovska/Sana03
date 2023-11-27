using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int count;
Console.WriteLine("Введіть кількість елементів масиву: ");
count = int.Parse(Console.ReadLine());
Random random = new Random();
double[] arr = new double[count];
double sum = 0;
double min = arr[0];
double max = arr[0];
int maxindex = 0;
double maxmod = arr[0];
int sum1 = 0;
int count1 = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Round(random.Next(-10, 11) + random.NextDouble(), 2);    
    Console.Write($"{arr[i]}  ");
    if (arr[i] < 0)
    {
        sum += arr[i];
    }
    if(min > arr[i])
    {
        min = arr[i];
    }
    if (max < arr[i])
    {
        max = arr[i];
        maxindex = i;  
    }
    if(maxmod < Math.Abs(arr[i]))
    {
        maxmod = arr[i];
    }
    if (arr[i] >= 0)
    {
        sum1 += i;
    }
    if (arr[i] % 1 == 0)
    {
        count1++;
    }
}
Console.WriteLine($"\nСума від'ємних елементів масиву: {sum}");
Console.WriteLine($"\nМінімальний елемент масиву: {min}"); 
Console.WriteLine($"\nНомер максимального елементу: {maxindex}");
Console.WriteLine($"\nМаксимальний за модулем елемент масиву: {min}");
Console.WriteLine($"\nСума індексів додатних елементів масиву: {sum1}");
Console.WriteLine($"\nКількість цілих чисел у масиві: {count1}");