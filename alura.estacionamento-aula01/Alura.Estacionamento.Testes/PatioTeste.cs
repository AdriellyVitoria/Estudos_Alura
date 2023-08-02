using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Testes
{
    public class PatioTeste : IDisposable
    {
        private Veiculo veiculo;
        private Operador operador;
        public ITestOutputHelper SaidaConsoleTeste;

        public PatioTeste(ITestOutputHelper _saidaConsoleTeste)
        {
            SaidaConsoleTeste = _saidaConsoleTeste;
            SaidaConsoleTeste.WriteLine("construtor invocado.");
            veiculo = new Veiculo();
            
            operador = new Operador();
            operador.Nome = "Pedro Fagundes";
        }

        [Fact]
        public void ValidaFaturamentoDoEstaciomantoComUmVeiculo()
        {
            //Arrange
            var estacionamento = new Patio();
            estacionamento.OperadorPatio = operador;
            //var veiculo = new Veiculo();
            veiculo.Proprietario = "André Solva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "asd-9999";

            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            // Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert 
            Assert.Equal(2, faturamento);

        }

        [Theory]
        [InlineData("André Silva", "ASD-1498", "Preto", "Gol")]
        [InlineData("José Silva", "POL-1498", "Cinza", "Fusca")]
        [InlineData("Maria Silva", "GDR-1498", "Azul", "Opala")]
        [InlineData("Mateus Silva", "PGT-1498", "Branco", "Corsa")]

        public void ValidaFaturamentoDoEstacionamentoComVariosVeiculos
            (string proprietario, string placa, string cor, string modelo)
        {
            //Arrange
            var estacionamento = new Patio();
            //Operador operador = new Operador();
            //operador.Nome ="Pedro Fale";
            estacionamento.OperadorPatio = operador;
            //var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Placa = placa;
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            // Act
            double faturamento = estacionamento.TotalFaturado ();
            //Assert
            Assert.Equal(2,faturamento);
        }

        [Theory]
        [InlineData("André Silva", "ASD-1498", "Preto", "Gol")]
        public void LocalizaVeiculoNoPatioComBaseNoIdTicket
            (string proprietario, string placa, string cor, string modelo)
        {

            //Arrange
            Patio estacionamento = new Patio();
            estacionamento.OperadorPatio = operador;
            //var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Placa = placa;
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            //estacionamento.Gerar? Ticket;


            // Act
            var consultado = estacionamento.PesquisaVeiculo(veiculo.IdTicker);

            // Assert
            Assert.Contains("### Ticker Estacionamento Alura ###", consultado.Ticker); 
        }

        [Fact]
        public void AlterarDadosDoProprioVeiculo()
        {
            //Arrange
            var estacionamento = new Patio();
            estacionamento.OperadorPatio = operador;
            //var veiculo = new Veiculo();
            veiculo.Proprietario = "José Silva";
            veiculo.Placa = "ZXC-9999";
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Fusca";
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Veiculo();
            veiculoAlterado.Proprietario = "José Silva";
            veiculoAlterado.Placa = "ZXC-9999";
            veiculoAlterado.Cor = "PRETO"; // Alterado
            veiculoAlterado.Modelo = "Fusca";

            //Act
            Veiculo alterado = estacionamento.AlterarDadosVeiculo(veiculoAlterado);

            // Assert
            Assert.Equal(alterado.Cor, veiculoAlterado.Cor); 
        }

        public void Dispose()
        {
            SaidaConsoleTeste.WriteLine("Dispose invocado.");
        }
    }
}
