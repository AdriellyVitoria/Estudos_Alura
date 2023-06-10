class Episodio
{
    public int Duracao { get; set; }
    public int Ordem { get; set; }
    public string Resumo { get; set; }
    public string Titulo { get; set; }

    public List<string> Convidados = new List<string>();
         
    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }

}