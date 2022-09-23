

/* A program that calculates the average of even numbers in a given list of numbers */
int[] numbers = new int[] { 2, 3, 4, 6 };
int summary = 0;
int count = 0;
int average;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count++;
        summary += numbers[i];
    }
}
average = summary / count;
Console.WriteLine(average);


 
/* The program that finds the longest of the given 5 numbers */
int[] ededler = new int[5] { 12, 15, 68, 55, 55 };
int maxeded = 0;
for (int i = 0; i < ededler.Length; i++)
{
    if (ededler[i] > maxeded)
    {
        maxeded = ededler[i];
    }
}
Console.WriteLine(maxeded);




/*A program that finds the sum of the digits of given numbers*/
int number = 554;
int sum = 0;
if (number > 0)
{
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    Console.WriteLine("Sum of digits:" + sum);
}
else
{
    Console.WriteLine(number + "Not natural number");
}