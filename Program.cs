Console.WriteLine("Faça um programa que implemente o meme Fluxograma da Engenharia .");
Console.WriteLine("--- Fluxograma Da Engenharia ---");
Console.WriteLine();

Console.Write("O objeto está se movendo (S/N)? ");
string respostaMovendo = Console.ReadLine()!.ToUpper();

Console.Write("Deveria (S/N)? ");
string respostaDeveria = Console.ReadLine()!.ToUpper();

Console.WriteLine();

if (respostaMovendo == "N")
{
    if (respostaDeveria == "N")
    {
        Console.WriteLine("Ótimo!");
    }
    else
    {
        Console.WriteLine("Use WD-40.");
    }
}
else
{
    if (respostaDeveria == "S")
    {
        Console.WriteLine("Ótimo!");
    }
    else
    {
        Console.WriteLine("Use Silver Tape.");
    }
}
