/*
Console.Write("Digite o nome do cliente: ");
string cliente = Console.ReadLine()!;

Console.Write("Digite o valor da compra: ");
double valorCompra = double.Parse(Console.ReadLine()!);

double desconto = 0;

if (valorCompra >= 200)
{
    desconto = valorCompra * 0.15;
}
else
{
    desconto = valorCompra * 0.05;
}

double valorFinal = valorCompra - desconto;

Console.WriteLine($"Cliente: {cliente}");
Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
Console.WriteLine($"Desconto: R$ {desconto:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
*/

// static void ExecultarSistema()
// {
//     string cliente = LerNomeCliente();
//     double valorCompra = LerValorCompra();
//     double desconto = CalcularDesconto(valorCompra);
//     double valorFinal = CalcularValorFinal(valorCompra, desconto);

//     ExibirResumo(cliente, valorCompra, desconto, valorFinal);
// }

// static string LerNomeCliente()
// {
//     Console.Write("Digite o nome do cliente: ");
//     string cliente = Console.ReadLine()!;
//     return cliente;
// }

// static double LerValorCompra()
// {
//     Console.Write("Digite o valor da compra: ");
//     double valorCompra = double.Parse(Console.ReadLine()!);
//     return valorCompra;
// }

// static double CalcularDesconto(double valorCompra)
// {
//     double desconto = 0;

//     if (valorCompra >= 200)
//     {
//         desconto = valorCompra * 0.15;
//     }
//     else
//     {
//         desconto = valorCompra * 0.05;
//     }
//     return desconto;
// }

// static double CalcularValorFinal(double valorCompra, double desconto)
// {
//     double valorFinal = valorCompra - desconto;
//     return valorFinal;
// }

// static void ExibirResumo(string cliente, double valorCompra, double desconto, double valorFinal)
// {
//     Console.WriteLine($"Cliente: {cliente}");
//     Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
//     Console.WriteLine($"Desconto: R$ {desconto:F2}");
//     Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
// }
// ExecultarSistema();