// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function getCities(){
  var select = document.getElementById('ufs');

  const request = new Request(`https://servicodados.ibge.gov.br/api/v1/localidades/estados/BA/municipios`);

  try {
    const response = await fetch(request);
    console.log(response.json() );

  }catch(err){
    alert(err);
  }
  
}
