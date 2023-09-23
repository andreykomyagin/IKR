// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Randome n = new Randome();
n = Next(1, 5);
string[] massiv = new string[n];

for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = Console.ReadLine();
}
for (int i = 0; i < massiv.Length; i++)
{
    Console.WriteLine(massiv[i]);
}


Console.WriteLine();

void Sorting(string[] massiv)
{
    int i = 0;
    while (i < massiv.Length)
    {
        if (massiv[i].Length == 3)
        {
            i++;
        }
    }
    Console.WriteLine($"Длина нового массива - {i}");
    Console.WriteLine();
    string[] massiv_2 = new string[i];

    if (i != 0)
    {
        for (int i = 0; i < massiv_2.Length; i++)
        {
            massiv_2[i] = "";
        }

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i].Length == 3)
            {
                for (int j = 0; j < massiv_2.Length; j++)
                {
                    if (massiv_2[j] != "")
                    {
                        massiv_2[j] = massiv[i];
                    }
                }
            }
        }

        for(int i = 0; i<massiv_2.Length; i++)
        {
            Console.WriteLine($"{massiv_2[i]} - {i+1} слово")
        }

        Console.WriteLine();
        Console.Write("Задание выполнено!");
    }
    else
    {
        Console.WriteLine("Таких слов нет!")
    }
}
