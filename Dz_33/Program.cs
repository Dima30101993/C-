Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N < 1)
{
    Console.WriteLine("Некоректные данные");
    return;
}
CubeTable(N);

void CubeTable(int num)
{
    for(int i = 1; i <= num; i++)
    {
        int cube = i * i * i;
        Console.WriteLine($"{i, 3}{cube, 5}");
    }
}
