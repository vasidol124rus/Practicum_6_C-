
        char[,] charArray = {
            { 'П', 'Р', 'И', 'В', 'Е', 'Т' },
            { 'М', 'Е', 'Д', 'В', 'Е', 'Д' }
        };

        string result = "";

        for (int i = 0; i < charArray.GetLength(0); i++)
        {
            for (int j = 0; j < charArray.GetLength(1); j++)
            {
                result += charArray[i, j];
            }
        }

        Console.WriteLine("Строка из символов массива: " + result);
    