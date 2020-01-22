function solve() {

    let chopButton = document.querySelector('#operations > button:nth-child(1)');
    let diceButton = document.querySelector('#operations > button:nth-child(2)');
    let spiceButton = document.querySelector('#operations > button:nth-child(3)');
    let bakeButton = document.querySelector('#operations > button:nth-child(4)');
    let filletButton = document.querySelector('#operations > button:nth-child(5)');

    chopButton.addEventListener('click', chopFunc);
    diceButton.addEventListener('click', diceFunc);
    spiceButton.addEventListener('click', spiceFunc);
    bakeButton.addEventListener('click',bakeFunc);
    filletButton.addEventListener('click', filletFunc);


    var output = document.querySelector('#output');

    function chopFunc(){
        let inputValue = Number(document.querySelector('#exercise > input').value);
        output.innerHTML=Number(inputValue/2);
    }

    function diceFunc(){
        let inputValue = Number(document.querySelector('#exercise > input').value);
        output.innerHTML = Math.sqrt(inputValue);
    }

    function spiceFunc(){
        let inputValue = Number(document.querySelector('#exercise > input').value);
        output.innerHTML = inputValue+1;
        
    }

    function bakeFunc(){
        let inputValue = Number(document.querySelector('#exercise > input').value);
        output.innerHTML = inputValue*3;
    }

    function filletFunc(){
        let inputValue = Number(document.querySelector('#exercise > input').value);
        output.innerHTML = inputValue*0.8;
    }
}
