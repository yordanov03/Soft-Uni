function solve() {
  let button = document.querySelector('#exercise > form > input[type=button]');
  button.addEventListener('click', calculate);

  let input =  JSON.parse(document.getElementById('arr').value);
  let result = document.getElementById('result');


  function calculate(){

    for (let i = 0; i < input.length; i++) {
      let paragraph = document.createElement('p');
      let calculated = Number(input[i])* input.length;
      paragraph.innerHTML =`${i} -> ${calculated}`;
      result.appendChild(paragraph);
      
    }
  }
}