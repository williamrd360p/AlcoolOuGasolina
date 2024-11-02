Console.Clear();
Console.WriteLine("Vamos ver se compensa abastecer com Alcool ou Gasolina.");
double Alcool;

Console.WriteLine("Digite o preço do Alcool (R$):");
Alcool = Convert.ToDouble(Console.ReadLine());


double Gasolina;
Console.WriteLine("Digite o preço da Gasolina (R$):");
Gasolina = Convert.ToDouble(Console.ReadLine());


RazaoAlcoolGasolina();

void RazaoAlcoolGasolina()
{
    double razao = (Alcool / Gasolina) * 100;

    Console.WriteLine("O preço do Alcool corresponde a " + razao.ToString("n2") + "% do preço da Gasolina.");

    Console.ForegroundColor = ConsoleColor.Green;
    if (razao > 68)
       
    {
        Console.WriteLine("Recomendação: Abasteça com Gasolina.");
    }
    else 
    {
        Console.WriteLine("Recomendação: Abasteça com Alcool.");
    }
    Console.ResetColor();
}