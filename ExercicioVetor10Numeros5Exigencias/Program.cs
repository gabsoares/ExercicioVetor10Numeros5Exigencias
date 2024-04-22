int[] numeros = new int[10];
int[] impares = new int[10];
int[] pares = new int[10];

for (int i = 0; i < 10; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Vetor normal");
for (int i = 0; i < 10; i++)
{
    Console.Write(numeros[i] + " ");
}
Console.WriteLine();

Console.WriteLine("De trás para frente");
for (int i = 9; i >= 0; i--)
{
    Console.Write(numeros[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Até a metade");
for (int i = 0; i <= 4; i++)
{
    Console.Write(numeros[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Pares");
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        pares[i] = numeros[i];
        Console.Write(pares[i] + " ");
    }
}
Console.WriteLine();

Console.WriteLine("Ímpares");
for (int i = 0; i < 10; i++)
{
    if (i % 2 != 0)
    {
        impares[i] = numeros[i];
        Console.Write(impares[i] + " ");
    }
}