class Podcast
{
    public string Host { get; set; }
    public string Nome { get; set; }

    public List<Episodio> Episodios = new List<Episodio>();
    public int TotalDeEpisodios { get => Episodios.Count; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Voce está vendo o Podcast {Nome} do {Host} Com {TotalDeEpisodios}");
    }
}