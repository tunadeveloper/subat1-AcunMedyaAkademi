
        int[] numbers = { 15, 42, 7, 89, 23 };
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
                max = num;
        }

        Console.WriteLine("En büyük sayı: " + max);
    }