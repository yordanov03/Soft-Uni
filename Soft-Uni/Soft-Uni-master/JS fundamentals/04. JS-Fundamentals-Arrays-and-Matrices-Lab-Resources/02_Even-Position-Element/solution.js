function solve() {
  let inputText = document.getElementById('arr').value;
  let inputArr = JSON.parse(inputText);
  let result = document.getElementById('result');
  let stringToPush=[];

  for (let i = 0; i < inputArr.length; i++) {
    if(i%2===0)
    stringToPush.push(inputArr[i]);
  }

  let resultText = stringToPush.join(' x ');
  result.innerHTML = resultText;
}