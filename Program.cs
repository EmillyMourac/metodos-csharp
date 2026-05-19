/*
DEsenvolva a solução aqui em Program.cs, quando terminar cole o conteúdo 
no respectivo arquivo
*/
/*

static void ExibirMenuConversao()
{
    Console.Clear();
    Console.WriteLine("=== CONVERSOR DE TEMPERATURA ===");
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.Write("Escolha uma opção: ");
}

static string LerOpcaoConversao()
{
    return Console.ReadLine()!;
}

static double LerTemperatura()
{
    Console.Write("Digite a temperatura: ");
    return double.Parse(Console.ReadLine()!);
}

static double ConverterCelsiusParaFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

static double ConverterFahrenheitParaCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}

static void ExibirResultadoConversao(double resultado, string unidade)
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: {resultado:F2} {unidade}");
}

static void ExecutarConversor()
{
    ExibirMenuConversao();

    string opcao = LerOpcaoConversao();
    double temperatura = LerTemperatura();

    switch (opcao)
    {
        case "1":
            double resultadoFahrenheit = ConverterCelsiusParaFahrenheit(temperatura);
            ExibirResultadoConversao(resultadoFahrenheit, "°F");
            break;

        case "2":
            double resultadoCelsius = ConverterFahrenheitParaCelsius(temperatura);
            ExibirResultadoConversao(resultadoCelsius, "°C");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

ExecutarConversor();
*/


/*
static string LerNomeAluno()
{
    Console.Write("Digite o nome do aluno: ");
    string nome = Console.ReadLine()!;
    return nome;
}

static double LerNota(string mensagem)
{
    Console.WriteLine(mensagem);
    double nota = double.Parse(Console.ReadLine()!);
    return nota;
}
static double CalcularMedia(double nota1, double nota2, double nota3)
{
    return (nota1 + nota2 + nota3) / 3;
}

static string VerificarSituacao(double media)
{
    if (media >= 7)
    {
        return "Aprovado";
    }
    else if (media >= 5 && media < 7)
    {
        return "em recuperação";
    }
    else
    {
        return "Reprovado";
    }
}

static void ExibirResultado(string nome, double media, string situação)
{
    Console.WriteLine();
    Console.WriteLine($"Aluno(a): {nome}");
    Console.WriteLine($"Media final: {media}");
    Console.WriteLine($"Situação: {situação}");
}
static void ExecutarSistema()

{

    string nome = LerNomeAluno();

    double nota1 = LerNota("Nota 1: ");
    double nota2 = LerNota("Nota 2: ");
    double nota3 = LerNota("Nota 3: ");

    double media = CalcularMedia(nota1, nota2, nota3);

    string situaçao = VerificarSituacao(media);

    ExibirResultado(nome, media, situaçao);
}
ExecutarSistema();
*/



/*
using System.Reflection;

static string concatenar(string nome, string sobrenome)
{
    string nomeSobrenome = nome + " " + sobrenome;
    return nomeSobrenome;
}

string concatenado = concatenar("Emilly", "Moura");
Console.WriteLine(concatenado);
*/


/*
static void concatenar()
{
    Console.WriteLine ("Digite o nome:");
    string nome = Console.ReadLine ()!;

    Console.WriteLine ("Digite o sobrenome:");
    string sobrenome = Console.ReadLine ()!;

string nomeSpbrenome = nome = " " + sobrenome;
Console.WriteLine (nomeSobrenome);

}

concatenar();
Console.WriteLine("Fim!!");
*/

/*
static void ExecultarSistema()
{
    string cliente = LerNomeCliente();
    double valorCompra = LerValorCompra();
    double desconto = CalcularDesconto(valorCompra);
    double valorFinal = CalcularValorFinal(valorCompra, desconto);

    ExibirResumo(cliente, valorCompra, desconto, valorFinal);
}

static string LerNomeCliente()
{
    Console.Write("Digite o nome do cliente: ");
    string cliente = Console.ReadLine()!;
    return cliente;
}

static double LerValorCompra()
{
    Console.Write("Digite o valor da compra: ");
    double valorCompra = double.Parse(Console.ReadLine()!);
    return valorCompra;
}

static double CalcularDesconto(double valorCompra)
{
    double desconto = 0;

    if (valorCompra >= 200)
    {
        desconto = valorCompra * 0.15;
    }
    else
    {
        desconto = valorCompra * 0.05;
    }
    return desconto;
}

static double CalcularValorFinal(double valorCompra, double desconto)
{
    double valorFinal = valorCompra - desconto;
    return valorFinal;
}

static void ExibirResumo(string cliente, double valorCompra, double desconto, double valorFinal)
{
    Console.WriteLine($"Cliente: {cliente}");
    Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
    Console.WriteLine($"Desconto: R$ {desconto:F2}");
    Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
}
ExecultarSistema();
*/

using System.Runtime.InteropServices;

static int LerNumeroTabela()
{
    Console.WriteLine("Digite o numero da tabuada:");
    int numero = int.Parse(Console.ReadLine()!);
    return numero;
}

static void ExibirTabuada(int numero)
{
    Console.WriteLine();

    int contador = 1;

    while (contador <= 10)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }

    Console.WriteLine();
}

static string LerContinuacao()
{
    Console.WriteLine("deseja consoltar outra tabuada? (s/n)");
    string resposta = Console.ReadLine()!;

    return resposta;
}

static bool DesejaContinuar(string resposta)
{
    if (resposta == "s" || resposta == "S")
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void ExecultarTabuada()
{
    Console.Clear();

    int numero = LerNumeroTabela();
    ExibirTabuada(numero);

    string resposta = LerContinuacao();

    if (DesejaContinuar(resposta))
    {
        ExecultarTabuada();
    }
    else
    {
        Console.WriteLine("programa encerrado.");
    }
}
ExecultarTabuada();