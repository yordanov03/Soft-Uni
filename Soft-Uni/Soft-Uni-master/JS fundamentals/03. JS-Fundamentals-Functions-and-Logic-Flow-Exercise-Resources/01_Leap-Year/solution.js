function leapYear() {
    
    let resultText = document.getElementsByTagName('h2')[0];
    let numberResult = document.querySelector('#year > div');
    let button = document.getElementsByTagName('button')[0];

    button.addEventListener('click', checkLeapYear);

    function checkLeapYear(){
        let inputValue = Number(document.querySelector('input').value);

        let isLeap = ((inputValue % 4 === 0) && (inputValue % 100 !== 0)) || (inputValue % 400 === 0);

        if (isLeap) {
            resultText.innerHTML = 'Leap Year';
        } else {
            resultText.innerHTML = 'Not Leap Year';
        }
        numberResult.textContent = inputValue;
        document.querySelector('#exercise input').value = '';
    }
    
}