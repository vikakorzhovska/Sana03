using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int count;
Console.WriteLine("Введіть кількість елементів масиву: ");
count = int.Parse(Console.ReadLine());
Random random = new Random();
int[] arr = new int[count];
int sum = 0;
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(-100, 101);
    Console.Write($"{arr[i]} ");
    if (arr[i] < 0)
    {
        sum += arr[i];
    }
    if(min > arr[i])
    {
        min = arr[i];
    }
}
Console.WriteLine($"\nСума від'ємних елементів масиву: {sum}");
Console.WriteLine($"\nМінімальний елемент масиву: {min}");