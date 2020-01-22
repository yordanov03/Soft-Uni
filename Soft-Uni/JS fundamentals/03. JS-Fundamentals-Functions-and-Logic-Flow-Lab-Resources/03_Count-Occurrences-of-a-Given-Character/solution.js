function solve() {
 
  let expression = document.getElementById('string').value;
  let symbol = document.getElementById('character').value;
  let result = document.getElementById('result');
  let count = 0;

  for (let index = 0; index < expression.length; index++) {
    if (expression[index]===symbol) {
      count++;
    }
    
  }

  if (count%2==0) {
    result.innerHTML=`Count of ${symbol} is even`;
  }
  else{
    result.innerHTML=`Count of ${symbol} is odd `;
  }
  
}