Console.WriteLine("Digite uma sequencia de números pares e dire a média deles");
int quanidade = int.Parse(Console.ReadLine());

int numero;
int soma = 0;
int contador= 0;
int i = 1;

if (numero %2 ==0 )
{
    
while(i <= quantidade )
{
  media = numero/quantidade;
  Console.WriteLine("A média dos números pares é :"+ media);
i ++;
}
}
else
{
    Console.WriteLine("Digite apenas números pares!");
}

