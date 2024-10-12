double altura, pesoIdeal;
string genero;


Console.WriteLine("Digite a sua altura em m..........:");
altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Genero [M]asculino / [F]eminino: ");
genero = Console.ReadLine()!.ToUpper().Trim();
if (genero != "M" && genero != "F")
{ Console.WriteLine("Nao obtenho a formula para realizar o calculo");
}
else 
{if (genero == "M")
{ pesoIdeal = altura * 72.7 - 58.0;
}
else
{ pesoIdeal = altura * 62.1 - 44.7;
}

Console.WriteLine($"O seu peso ideal é {pesoIdeal:N1}kg");
}