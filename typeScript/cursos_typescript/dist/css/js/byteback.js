var saldo = 3000;
var elementoSaldo = document.querySelector(".saldo-valor .valor");
if (elementoSaldo !== null) {
    elementoSaldo.textContent = saldo.toString();
}
var elementoFormulariuo = document.querySelector(".block-nova-transacao form");
elementoFormulariuo.addEventListener("submit", function (event) {
    event.preventDefault();
    if (!elementoFormulariuo.checkValidity()) {
        alert("Por favor, preencha o campo de translação");
        return;
    }
    var inputTipoTransacao = elementoFormulariuo.querySelector("#tipoTransacao");
    var inputValor = elementoFormulariuo.querySelector("#valor");
    var inputData = elementoFormulariuo.querySelector("#data");
    var tipoTransacao = inputTipoTransacao.value;
    var valor = inputValor.valueAsNumber;
    var data = new Date(inputData.value);
    if (tipoTransacao == "Depósito") {
        saldo += valor;
    }
    else if (tipoTransacao == "Transferência" || tipoTransacao == "Pagamento de Boleto") {
        saldo -= valor;
    }
    else {
        alert("Tipo de Transação é inválido");
        return;
    }
    elementoSaldo.textContent = saldo;
    var novaTransacao = {
        tipoTransacao: tipoTransacao,
        valor: valor,
        data: data,
        isNova: true
    };
    console.log(novaTransacao);
    elementoFormulariuo.reset();
});
