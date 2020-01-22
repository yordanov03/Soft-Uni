function solve() {
let input = document.getElementById('str').value;
let number = Number(document.getElementById('num').value);
let resultString = [];

for (let i = 0; i <= input.length; i++) {
  if (i%number===0) {
    resultString.push(input.substring(i-number,i));
  }
  
}
document.getElementById('result').innerHTML = resultString.join(' ');

}