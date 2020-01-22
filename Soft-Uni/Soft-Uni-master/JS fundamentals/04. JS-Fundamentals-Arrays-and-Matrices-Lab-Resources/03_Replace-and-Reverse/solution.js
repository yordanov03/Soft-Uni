function solve() {
  let inputText = document.getElementById('arr').value;
  let inputArr = JSON.parse(inputText);
  let result = document.getElementById('result');

  inputArr.forEach(word => word.split('').reverse().join(''));

  let resultArr = inputArr.map(word=> word.charAt(0).toUpperCase()+word.slice(1));
  result.innerHTML = resultArr.join(' ');
}