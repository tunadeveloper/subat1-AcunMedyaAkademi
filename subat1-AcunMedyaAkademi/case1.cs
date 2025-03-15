int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Lütfen {i + 1}. sayıyı girin: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Girilen Sayılar:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}
