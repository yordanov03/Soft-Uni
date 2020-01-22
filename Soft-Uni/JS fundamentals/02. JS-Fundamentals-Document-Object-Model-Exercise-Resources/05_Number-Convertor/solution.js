function solve() {
    
let convertBtn = document.getElementsByTagName('button')[0];
let binaryOption = document.querySelector('#selectMenuTo option');
binaryOption.textContent='Binary';

let hexOption = document.createElement('option');
hexOption.textContent = 'Hexadecimal';

let selectElementTo = document.getElementById('selectMenuTo');
selectElementTo.appendChild(hexOption);

convertBtn.addEventListener('click', ()=>{
    let inputNum = document.getElementById('input').value;
    inputNum = Number(inputNum);
    if(inputNum < 0){
        inputNum = 0xFFFFFFFF + inputNum + 1;
    }
    if(binaryOption.selected){
        let result =  parseInt(inputNum).toString(2);
        document.getElementById('result').value = result;
    }else{
        let result =  parseInt(inputNum).toString(16);
        document.getElementById('result').value = result.toUpperCase();
    }
});

}