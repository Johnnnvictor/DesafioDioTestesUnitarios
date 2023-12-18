using System.ComponentModel;
using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista teste = new ValidacoesLista{};
List <int> lista = new List<int>(3);
lista.Add(10);
lista.Add(50);
lista.Add(120);

int numero = 12;

teste.RemoverNumerosNegativos(lista);
teste.MultiplicarNumerosLista(lista, numero);
teste.RetornarMaiorNumeroLista(lista);
teste.ListaContemDeterminadoNumero(lista, numero);

Console.WriteLine(teste.RemoverNumerosNegativos(lista));
Console.WriteLine(teste.MultiplicarNumerosLista(lista, numero));
Console.WriteLine(teste.RetornarMaiorNumeroLista(lista));
Console.WriteLine(teste.ListaContemDeterminadoNumero(lista, numero));

foreach (int num in lista)
{
Console.WriteLine(num);
}






