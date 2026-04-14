class Exercicios
{
    public static void Exercicio1()
    {
        /*Crie um array de int com 5 notas de alunos (valores à sua escolha). Em seguida, percorra o array com um for e exiba cada nota no console.*/

int[] notas = {8, 7, 4, 7, 10};
int cont = 0;

Console.WriteLine();
for(int i = 0; i < notas.Length; i++)
{
    cont += 1;
    Console.WriteLine($"A {cont}° nota é: {notas[i]}");
}
    }

    public static void Exercicio2()
    {
        /*Crie um array com 6 valores double representando temperaturas de 
uma semana (sem domingo). Calcule e exiba a soma e a média das temperaturas.

Dica: use array.Length para calcular a média.*/


double[] temperaturas = new double[6];
temperaturas[0] = 28;
temperaturas[1] = 31;
temperaturas[2] = 30;
temperaturas[3] = 31;
temperaturas[4] = 32;
temperaturas[5] = 18;

double media = (temperaturas.Sum() /  temperaturas.Length);
Console.WriteLine("\n");
Console.WriteLine($"A media das temperaturas desta semana é {media:F1}°.");
    }

    public static void Exercicio3()
    {
        /*Crie um array de 8 inteiros com valores variados. Percorra o array e encontre o maior e o menor valor, sem usar métodos prontos como Max() ou Min().*/

int[] numeros = {2, 4, 6, 8, 10, 22, 24, 36};

int maior = 0;
int menor = 99;

for(int i = 0; i < numeros.Length; i++)
{
    if(numeros[i] > maior)
    {
        maior = numeros[i];
    }
    if(numeros[i] < menor)
    {
        menor = numeros[i];
    }
}
Console.WriteLine("\n");
Console.WriteLine($"O maior número é: {maior}.\nO menor número é: {menor}.");
    }

    public static void Exercicio4()
    {
        /*Dado o array string[] palavras = { "C#", "é", "muito", "legal" };, exiba os elementos na ordem inversa sem usar Array.Reverse()*/

String[] palavras = { "C#", "é", "muito", "legal" };

Console.WriteLine("\n");
for(int i = 3; i >= 0; i--)
{
    Console.WriteLine(palavras[i]);
}

    }

    public static void Exercicios5()
    {
        /*Crie um array de 10 inteiros. Percorra o array e conte quantos números são pares e quantos são ímpares.*/

int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 11};
int numeros_par = 0;
int numeros_impar = 0;

for(int i = 0; i < numeros.Length; i++)
{
    if(numeros[i] % 2 == 0)
    {
        numeros_par += 1;
    }
    else
    {
        numeros_impar += 1;
    }
}
Console.WriteLine($"Existem {numeros_par} números par e {numeros_impar} números impar neste array.");
    }

    public static void Exercicios6()
    {
       /* Crie um programa de lista de compras usando List<string>. O programa deve:

Começar com 3 itens já na lista
Adicionar 2 itens novos com Add()
Remover 1 item com Remove()
Exibir a lista final com foreach
Exibir a quantidade total de itens com Count*/

List<string> estoque = new List<string>{"BANANA", "MAÇA", "PERA"};
Boolean ativo = false;

        while (!ativo)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Estoque\n1° Adicionar item\n2° Remover item\n3° Fechar\n");
            string r = Console.ReadLine();

            switch (r)
            {
                
                case "1":
                Console.WriteLine("Digite o item que deseja adicionar: ");
                string item = Console.ReadLine().ToUpper();

                estoque.Add(item);
                break;

                case "2":
                Console.WriteLine("Digite o item que deseja remover: ");
                string item2 = Console.ReadLine().ToUpper();

                estoque.Remove(item2);
                if (estoque.Remove(item2))
                {
                    Console.WriteLine("Item removido!");
                }
                else
                {
                    Console.WriteLine("Item não encontrado!");
                }
                break;

                case "3":
                foreach(string produto in estoque)
                    {
                        Console.WriteLine(produto);
                    }
                ativo = true;
                break;

            }


        }

    }
}

