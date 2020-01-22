function solve() {
  let inputText = document.getElementById('str').value;
  let resultElement = document.getElementById('result');

  let numbers = [];
  inputText.split(' ').filter(x=>x).forEach(x => {
    
    if (isNaN(x)) {
      let resultRow = x.split('').map(ch=>ch.charCodeAt(0)).join(' ');
      let paragraphElement = document.createElement('p');
      paragraphElement.innerHTML = resultRow;
      resultElement.appendChild(paragraphElement);
    }
    else{
      numbers.push(x);
    }
  });

  let lastWord = String.fromCharCode(...numbers);
  let paragraphElement = document.createElement('p');
      paragraphElement.innerHTML = lastWord;
      resultElement.appendChild(paragraphElement);
}