Console.WriteLine("Hello, World!");

List<int> list = new();

while (list.Count < 3)
{
    Console.Write("Valor: ");
    int valor = int.Parse(Console.ReadLine());
    list.Add(valor);
}

foreach (int val in list)
{
    Console.WriteLine(val);
}
