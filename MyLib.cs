public static class MyLib8
{
    //1. Меиод создания массива

    public static int[,] CreateMatrix(int row, int columns)
    {
        return new int[row, columns];

    }

    //2. Заполнение двумерного массива

    public static void FillMatrix(int[,] array)
    {
        Random rnd = new Random();
        int SizeRows = array.GetLength(0);
        int SizeCol = array.GetLength(1);
        for (int i = 0; i < SizeRows; i++)
        {
            for (int j = 0; j < SizeCol; j++)
            {
                array[i, j] = rnd.Next(0, 10);
            }
        }
    }
    //3. Метод печати массиваЖ

    public static void PrintMatrix(int[,] matr)
    {
        int SizeRows = matr.GetLength(0);
        int SizeCol = matr.GetLength(1);
        for (int i = 0; i < SizeRows; i++)
        {
            for (int j = 0; j < SizeCol; j++)
            {
                Console.Write($" {matr[i, j]}  ");
            }
            Console.WriteLine();
        }

    }

    //4. Метод сортировки матрицы
    public static void Sort(int[,] matrix)
    {
        int sizeI = matrix.GetLength(0);
        int sizeJ = matrix.GetLength(1);
        int temp = 0;

        for (int i = 0; i < sizeI; i++)
        {
            for (int k = 0; k < sizeJ; k++)
            {
                for (int j = 0; j < sizeJ - 1; j++)
                {
                    if (matrix[i, j] < matrix[i, j + 1])
                    {
                        temp = matrix[i, j];
                        matrix[i, j] = matrix[i, j + 1];
                        matrix[i, j + 1] = temp;
                    }
                }

            }
            temp = matrix[i, 1];
        }

    }
    // 5. метод вывода строки с наименьшей суммой элементов

    public static void MinSumRows(int[,] matrix)
    {
        int sizeI = matrix.GetLength(0);
        int sizeJ = matrix.GetLength(1);
        int sum = 0;
        int[] temp = new int[matrix.GetLength(0)];
        //создаем массив из сумм строк
        for (int i = 0; i < sizeI; i++)
        {
            for (int j = 0; j < sizeJ; j++)
            {
                sum += matrix[i, j];
            }

            temp[i] = sum;
            sum = 0;
        }
        //печатем массив сумм и находим меньшее
        int min = temp[0];
        int index = 1;
        for (int i = 0; i < temp.Length; i++)
        {
            Console.WriteLine($"сумма {i + 1} строки равно {temp[i]} ");
            if (temp[i] < min)
            {
                min = temp[i];
                index = i;
            }
        }
        Console.WriteLine($"Минимальная сумма элементов в -->{index + 1} строке");



    }


    //6.Метод создания трехмерного массива.
    public static int[,,] CreateCube(int x, int y, int z)
    {
        return new int[x, y, z];

    }

    //7. Метод заполнения трехмерного массив.
    public static void FillCube(int[,,] array)
    {
        Random rnd = new Random();
        int SizeX = array.GetLength(0);
        int SizeY = array.GetLength(1);
        int SizeZ = array.GetLength(2);
        for (int i = 0; i < SizeX; i++)
        {
            for (int j = 0; j < SizeY; j++)
            {
                for (int k = 0; k < SizeZ; k++)
                {
                    array[i, j, k] = rnd.Next(0, 10);
                }

            }
        }
    }


    //8.Метод вывода массива трехмерного с указанием его индексов.

    public static void PrintCube(int[,,] matr)
    {
        int SizeX = matr.GetLength(0);
        int SizeY = matr.GetLength(1);
        int SizeZ = matr.GetLength(2);
        for (int i = 0; i < SizeX; i++)
        {
            for (int j = 0; j < SizeY; j++)
            {
                for (int k = 0; k < SizeZ; k++)
                {
                    Console.Write($"{matr[i, j, k]}({i},{j},{k})  ");
                }

            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
    public static int[,] MultiplyMatrix(int[,] first, int[,] second)
    {
        int[,] MultiplyMatrix = new int[first.GetLength(0), second.GetLength(1)];
        if (first.GetLength(1) == second.GetLength(0))
        {
            for (int i = 0; i < first.GetLength(0); i++)
            {
                for (int j = 0; j < second.GetLength(1); j++)
                {
                    for (int k = 0; k < first.GetLength(1); k++)
                    {
                        MultiplyMatrix[i, j] += first[i, k] * second[k, j];
                    }

                }
            }
        }
        else Console.WriteLine($"Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");

        return MultiplyMatrix;
    }



}























