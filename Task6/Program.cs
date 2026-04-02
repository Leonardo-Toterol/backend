/*Crie um array de int com 5 notas de alunos (valores à sua escolha). Em seguida, percorra o array com um for e exiba cada nota no console.*/

List<int> notas = new List<int>{10, 8, 4, 6, 9};
int cont = 1;

for(int i = 0; i < notas.Count; i++)
{
    Console.WriteLine($"a {cont}° nota é {notas[i]}. ");
    cont += 1;
}


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
float mediaSmall = (float)media;

Console.WriteLine($"A media das temperaturas desta semana é {mediaSmall}°.");




