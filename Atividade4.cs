/*
double[] notasAlunos = { };
string continuar = "s";


while (continuar == "s")
{
    Console.Write("Digite a nota do aluno: ");
    double nota = double.Parse(Console.ReadLine()!);

    notasAlunos = notasAlunos.Append(nota).ToArray();

    Console.Write("Deseja continuar? (s/n): ");
    continuar = Console.ReadLine()!.ToLower();

    Console.Clear();
    Console.WriteLine($"Notas do aluno: {string.Join(", ", notasAlunos)}");

    if (continuar != "s")
    {
        Console.WriteLine($"Média do aluno: {notasAlunos.Average():F2}");
        break;
    }
}
*/