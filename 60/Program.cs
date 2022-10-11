// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
Console.Clear();
int[,,] NewArray2(int m, int n, int o)
{
    int[,,] a = new int[m, n, o];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < o; k++)
            {
                int num = new Random().Next(10, 100);
                while (IsInArray(num, i, j, k, a) == true)
                {
                    num = new Random().Next(10, 100);
                }
                a[i, j, k] = num;
                Console.Write("[{0, 2},{1, 2},{2, 2}]{3, 3} ", i, j, k, a[i, j, k]);
            }
            Console.WriteLine();
        }
    }
    return a;
}
Console.WriteLine("Введите количество строк, столбцов и уровней массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int o = Convert.ToInt32(Console.ReadLine());
if (m * n * o <= 90)
{
    int[,,] a = NewArray2(m, n, o);
}
else Console.WriteLine("невозможно задать массива данного размера с уникальными 2-значными числами");
bool IsInArray(int x, int y, int b, int c, int[,,] a)
{
    bool flag = false;
    for (int i = 0; i <= y; i++)
    {
        for (int j = 0; j <= b; j++)
        {
            for (int k = 0; k < a.GetLength(2); k++)
            {
                if (a[i, j, k] == x)
                {
                    flag = true;
                    break;
                }
            }

        }
    }

    return flag;
}