function binarySearch() {
    let button = document.querySelector('#exercise > form > input[type=button]');
    button.addEventListener('click', findIndex);
    let result = document.getElementById('result');
   

   function findIndex(){
    let numbers = document.getElementById('arr').value.split(', ');
    let searchedNumber = document.getElementById('num').value;
    let index = numbers.indexOf(searchedNumber);

    if (index===-1) {
        result.innerHTML = `${searchedNumber} is not in the array`
    }

    else{
        result.innerHTML = `Found ${searchedNumber} at index ${index}`
    }

   }

}