// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function getCities() {
  $("#cities").empty();

  var o = new Option("Carregando...", "none");
  $(o).html("Carregando...");
  $("#cities").append(o);

  var uf = $('#ufs').val();

  const request = new Request(`https://servicodados.ibge.gov.br/api/v1/localidades/estados/${uf}/municipios`);

  fetch(request)
    .then(response => {
      response.json()
        .then(data => {
          $("#cities").empty();
          data.forEach(element => {
            var o = new Option(element.nome, element.nome);
            $(o).html(element.nome);
            $("#cities").append(o);
          });
        })
    })
}

