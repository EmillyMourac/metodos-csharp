/*
Um professor deseja criar um programa para ajudar alunos do ensino fundamental a 
estudar tabuada. O sistema deve permitir que o usuário escolha um número e exibir 
a tabuada de 1 até 10.
*/

// static int LerNumeroTabela()
// {
//     Console.WriteLine("Digite o numero da tabuada:");
//     int numero = int.Parse(Console.ReadLine()!);
//     return numero;
// }

// static void ExibirTabuada(int numero)
// {
//     Console.WriteLine();

//     int contador = 1;

//     while (contador <= 10)
//     {
//         Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//         contador++;
//     }

//     Console.WriteLine();
// }

// static string LerContinuacao()
// {
//     Console.WriteLine("deseja consoltar outra tabuada? (s/n)");
//     string resposta = Console.ReadLine()!;

//     return resposta;
// }

// static bool DesejaContinuar(string resposta)
// {
//     if (resposta == "s" || resposta == "S")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// static void ExecultarTabuada()
// {
//     Console.Clear();

//     int numero = LerNumeroTabela();
//     ExibirTabuada(numero);

//     string resposta = LerContinuacao();

//     if (DesejaContinuar(resposta))
//     {
//         ExecultarTabuada();
//     }
//     else
//     {
//         Console.WriteLine("programa encerrado.");
//     }
// }
// ExecultarTabuada();


// static int LerNumeroTabela()
// {
//     Console.WriteLine("Digite o numero da tabuada:");
//     int numero = int.Parse(Console.ReadLine()!);
//     return numero;
// }

// static void ExibirTabuada(int numero)
// {
//     Console.WriteLine();

//     int contador = 1;

//     while (contador <= 10)
//     {
//         Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//         contador++;
//     }

//     Console.WriteLine();
// }

// static string LerContinuacao()
// {
//     Console.WriteLine("deseja consoltar outra tabuada? (s/n)");
//     string resposta = Console.ReadLine()!;

//     return resposta;
// }

// static bool DesejaContinuar(string resposta)
// {
//     if (resposta == "s" || resposta == "S")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// static void ExecultarTabuada()
// {
//     Console.Clear();

//     int numero = LerNumeroTabela();
//     ExibirTabuada(numero);

//     string resposta = LerContinuacao();

//     if (DesejaContinuar(resposta))
//     {
//         ExecultarTabuada();
//     }
//     else
//     {
//         Console.WriteLine("programa encerrado.");
//     }
// }
// ExecultarTabuada();