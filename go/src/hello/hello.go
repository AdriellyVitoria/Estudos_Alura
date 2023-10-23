package main

import (
	"fmt"
	"net/http"
	"os"
)

func main() {
	exibiNomes()

	exibeIntroducao()


	for {		
		exibirMenu()

		comando := leComando()

		switch comando {
		case 1:
			IniciarMonitoramento()
		case 2 :
			fmt.Println("Exibindo Logs...")
		case 0:
			fmt.Println("Saindo do programa...")
			os.Exit(0)
		default :		
			fmt.Println("Não conheço esse comando")
			os.Exit(-1)
		}
	}
	
}

func exibeIntroducao() {
	nome := "adrielly"
	versao := 1.1
	fmt.Println("Olá, sra.", nome)
	fmt.Println("Este programa está na", versao)
}

func exibirMenu(){
	fmt.Println("1 - Iniciar Monitoramento")
	fmt.Println("2 - Exibir Logs")
	fmt.Println("0 - Sair do programa")
}

func leComando() int {
	var comandoLido int
	fmt.Scan(&comandoLido)
	fmt.Println("O comando escolhido foi", comandoLido)

	return comandoLido
}

func IniciarMonitoramento() {
	fmt.Println("Monitoramento")
	var sites [4]string
	sites[0] = "https://random-status-code.herokuapp.com/"
	sites[1] = "https://www.alura.com.br"
	sites[3] = "https://www.caelum.com.br"



	fmt.Println(sites)
	
	// https://www.alura.com.br
	site := "https://random-status-code.herokuapp.com/"
	resp,_ := http.Get(site)
	
	if resp.StatusCode == 200 {
		fmt.Println("Site:", site, "Foi carregado com sucesso")
	} else {
		fmt.Println("Site: ", site, "Está com problemas, Status Code:", resp.StatusCode)
	}
}

func exibiNomes(){
	nomes := []string{"Douglas", "Daniel", "Adrielly"}
	fmt.Println(nomes)
}