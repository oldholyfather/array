// See https://aka.ms/new-console-template for more information

int[] array = new int[5];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(25);
    Console.WriteLine(array[i]);
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum = array[i] + sum;
}
Console.WriteLine(sum);

