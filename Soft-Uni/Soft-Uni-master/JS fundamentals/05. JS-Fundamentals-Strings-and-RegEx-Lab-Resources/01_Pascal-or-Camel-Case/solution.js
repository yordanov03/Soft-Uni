function solve() {
  let button = document.querySelector('#exercise > form > input[type=button]');
  button.addEventListener('click', transformString);

  function transformString(){
    let firstString = document.getElementById('str1').value.toLowerCase().split(' ').filter(a=>a!=='').map(e=>e.charAt(0).toUpperCase()+e.slice(1)).join('');
    let secondString = document.getElementById('str2').value;
    let result = document.getElementById('result');
    result.innerHTML = firstString;

    if (secondString==='Camel Case') {
      result.innerHTML=firstString.charAt(0).toLowerCase() + firstString.slice(1);

    }
    else if(secondString!='Pascal Case'){
      result.innerHTML = 'Error!'
    }
  }
}