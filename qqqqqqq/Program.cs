// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] massiv = new string[5];

for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = Console.ReadLine();
}
Console.WriteLine();
for (int i = 0; i < massiv.Length; i++)
{
    Console.WriteLine(massiv[i]);
}


Console.WriteLine();
int b = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i].Length == 3)
    {
        b++;
    }
}
Console.WriteLine(b);


int l = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i].Length == 3)
    {
        l++;
    }
}
Console.WriteLine($"Длина нового массива - {l}");
Console.WriteLine();
string[] massiv_2 = new string[l];

if (l != 0)
{
    for (int j = 0; j < massiv_2.Length; j++)
    {
        massiv_2[j] = "";
    }
    int nomer = 0;
    int nomer_2 = 0;

    while (nomer < massiv.Length)
    {
        if (massiv[nomer].Length == 3)
        {
            massiv_2[nomer_2] = massiv[nomer];
            nomer_2++;
        }
        nomer++;
    }



    for (int j = 0; j < massiv_2.Length; j++)
    {
        Console.WriteLine($"{massiv_2[j]}" + $" - {j + 1} слово");
    }

    Console.WriteLine();
    Console.Write("Задание выполнено!");
}
else
{
    Console.WriteLine("");
    Console.WriteLine("Таких слов нет!");
}

