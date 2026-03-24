Console.WriteLine("Digite um número e direi se ele é par ou ímpar ");
int x = int.Parse(Console.ReadLine());
if (x%2 == 0)
{
    Console.WriteLine("O número digitado é par ");
}
else if (x % 2 == 1)
{
    Console.WriteLine("O número digitado é ímpar ");
}
else
{
    Console.WriteLine("O número digitado é par");
}