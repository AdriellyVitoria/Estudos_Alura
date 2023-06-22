using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns;

public class Iss : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }
}
