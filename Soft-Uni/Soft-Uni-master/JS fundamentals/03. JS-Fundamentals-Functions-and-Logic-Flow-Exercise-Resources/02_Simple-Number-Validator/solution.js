function validate() {
    
    let button = document.querySelector('#exercise > fieldset > div > button');
    let result = document.getElementById('response');

    button.addEventListener('click', validateNumbers);

    function validateNumbers(){
    let input = Array.from(document.querySelector('#exercise > fieldset > div > input[type=number]').value);
      let sum=0;
      let lastNum = +input[9];
      console.log(lastNum);

      
      let weights = [2, 4, 8, 5, 10, 9, 7, 3, 6];

      for (let i = 0; i < 9; i++) {
          sum+= +input[i] * +weights[i];
          console.log(input[i]);
          console.log(weights[i]);
      }
      

      if (sum%11===lastNum || ((sum%11===10)&& lastNum===0)) {
          result.innerHTML = 'This number is Valid!';
      }
      else{
        result.innerHTML = 'This number is NOT Valid!';
      }
    }
}