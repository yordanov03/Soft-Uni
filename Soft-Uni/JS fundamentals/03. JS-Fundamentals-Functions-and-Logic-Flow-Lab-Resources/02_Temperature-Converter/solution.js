function solve() {
  let inputNumber = Number(document.getElementById('num1').value);
  let conversionType = document.getElementById('type').value.toLowerCase();
  let result = document.getElementById('result');

  function convert(inputNumber, conversionType){

    let convertedValue=0;

    if (conversionType==='celsius') {
      convertedValue =Math.round(((inputNumber*9)/5)+32);
      result.innerHTML=convertedValue;
    }
    else if(conversionType==='fahrenheit'){
    convertedValue=Math.round((((inputNumber-32)*5)/9));
    result.innerHTML=convertedValue;
    }

    else{
      result.innerHTML='Error!';
    }
  }
 
convert(inputNumber,conversionType);
}