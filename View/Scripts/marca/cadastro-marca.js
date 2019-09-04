/*
$(function () {

    $('#botao-marca-salvar').on('click', function () {
        //pega o nome que usuario inseriu
        var nomeMarca = $('#campo-nome').val();

        adicionarLinhaNaTabela(0, nomeMarca);

        //limpa campo nome
        $('#campo-nome').val("");
    });


    function adicionarLinhaNaTabela(id, nome) {
        //pega a tabela
        var tabela = $('#tabela-marcas');

        //Tr = linha // criar linha
        var tr = document.createElement('tr');
        //td = coluna // criar coluna
        var td = document.createElement('td');
        var td2 = document.createElement('td');
        var td3 = document.createElement('td');

        //adicionar informacao nas colunas
        td.innerHTML = id;
        td2.innerHTML = nome;
        td3.innerHTML = "Ações";

        //AppendChild = linka na tr o td (ou seja.. atribui informacao para cada coluna)
        tr.appendChild(td);
        tr.appendChild(td2);
        tr.appendChild(td3);

        //adicionar a tr (linha) na tabela
        tabela.append(tr);
    }
});
*/