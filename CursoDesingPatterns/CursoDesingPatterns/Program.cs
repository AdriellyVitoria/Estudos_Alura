using CursoDesingPatterns;

IImposto iss = new Iss();
IImposto icms = new Icms();

Orcamento orcamento = new Orcamento(500.0);

CalculadorDeImpostos calcilador = new CalculadorDeImpostos();

calcilador.RealizaCalculo(orcamento, icms);
calcilador.RealizaCalculo(orcamento, iss);