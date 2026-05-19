string[] nomes = { "Kenneth", "Pedro", "João", "Rafaela", "Mariana" };

Console.WriteLine("Nomes dos alunos de trás para frente:");
for (int i = nomes.Length - 1; i >= 0; i--)
{
    Console.WriteLine(nomes[i]);
}