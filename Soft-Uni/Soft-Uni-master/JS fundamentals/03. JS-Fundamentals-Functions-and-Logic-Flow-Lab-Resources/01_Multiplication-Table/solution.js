function solve() {
let num1 = Number(document.getElementById('num1').value);
let num2 = Number(document.getElementById('num2').value);
var divResult = document.getElementById('result');

function findWrongInput(num1, num2){

  if(num1> num2){
    divResult.innerHTML='Try with other numbers.'
  }
}
function printTable(num1, num2){

  for (let index = num1; index <= num2; index++){
    let result = index * num2;
    let paragraph = document.createElement('p');
    paragraph.innerHTML=`${index} * ${num2} = ${result}`;
    divResult.appendChild(paragraph);
  }
}
divResult.innerHTML='';
findWrongInput(num1, num2);
printTable(num1,num2);
}
