let saldo = 3000;

alert("outra frase");

const elementoSaldo = document.querySelector(`.saldo-valor .valor`) as HTMLElement
if (elementoSaldo !== null) {
    elementoSaldo.textContent = saldo.toString();
}


const elementoFormulariuo = document.querySelector(`.block-nova-transacao form`) as HTMLFormElement;
elementoFormulariuo.addEventListener(`submit`, function(event){
    event.preventDefault();
    if (!elementoFormulariuo.checkValidity()) {
        alert("Por favor, preencha o campo de translação");
        return;
    }

    const inputTipoTransacao = elementoFormulariuo.querySelector(`#tipoTransacao`) as HTMLSelectElement;
    const inputValor = elementoFormulariuo.querySelector(`#valor`) as HTMLInputElement;
    const inputData = elementoFormulariuo.querySelector(`#data`) as HTMLInputElement;

    let tipoTransacao: string = inputTipoTransacao.value;
    let valor: number = inputValor.valueAsNumber;
    let data: Date = new  Date(inputData.value);

    if(tipoTransacao == "Depósito") {
        saldo += valor;
    } else if (tipoTransacao == "Transferência" || tipoTransacao == "Pagamento de Boleto") {
        saldo -= valor;
    } else {
        alert ("Tipo de Transação é inválido")
        return;
    }

    elementoSaldo.textContent = saldo.toString();

    const novaTransacao = {
        tipoTransacao: tipoTransacao,
        valor: valor,
        data: data ,
        isNova: true
    }

    console.log(novaTransacao);
    elementoFormulariuo.reset();

});